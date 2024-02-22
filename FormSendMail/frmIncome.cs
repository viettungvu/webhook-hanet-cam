using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormSendMail.Ext;
using Infra.EF;
using Infra.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Diagnostics.Metrics;
using System.Net.Mime;

namespace FormSendMail
{
    public partial class frmIncome : Form
    {
        private readonly HRMDbContext _context;
        private readonly IConfiguration _configuration;
        public frmIncome(HRMDbContext context, IConfiguration config)
        {
            _context = context;
            _configuration = config;
            InitializeComponent();
        }


        #region Private variable
        private BackgroundWorker _workerSendMail;
        private ContextMenuStrip _menuContext;
        #endregion

        private void initMenuContext()
        {
            _menuContext = new ContextMenuStrip();
            ToolStripMenuItem guiLuongContextItem = new ToolStripMenuItem()
            {
                Text = "Gủi bảng lương cho NV đã chọn",
                ShortcutKeys = Keys.F10,
            };
            guiLuongContextItem.Click += guiLuongUserChon;
            _menuContext.Items.Add(guiLuongContextItem);
        }



        private void frmIncome_Load(object sender, EventArgs e)
        {
            initDepartment();
            initGrid();
            initMenuContext();
            initControl();
            initData();
        }

        private void initControl()
        {
            setStateBtnSendMail(false);
        }

        private void initGrid()
        {
            dgvData.AddColumn("UserId", "UserId");
            dgvData.AddColumn("FullName", "FullName");
            dgvData.AddColumn("DepartmentId", "DepartmentId");
            dgvData.AddColumn("DepartmentFullname", "DepartmentFullname");
            dgvData.AddColumn("IncomeEmployeeId", "IncomeEmployeeId");
            dgvData.AddColumn("DataDate", "DataDate");
            dgvData.AddColumn("TotalIncome", "TotalIncome");
            dgvData.AddColumn("ThucLinh", "ThucLinh");
            dgvData.MouseClick += openMenuContext;
        }

        private void openMenuContext(object? sender, MouseEventArgs arg)
        {
            if (arg.Button == MouseButtons.Right)
            {
                _menuContext.Show(Cursor.Position);
            }
        }





        private void setStateBtnSendMail(bool isEnable)
        {
            btnSendMail.Enabled = isEnable;
        }
        private void setDataToGrid(IEnumerable<ViewIncomeEmployee> incomes)
        {
            dgvData.Rows.Clear();
            int total = incomes.Count();
            setTextTotal(total);
            setStateBtnSendMail(total > 0);
            foreach (ViewIncomeEmployee income in incomes)
            {
                dgvData.Rows.Add(income.UserId,
                    income.FullName,
                    income.DepartmentId,
                    income.DepartmentFullName,
                    income.IncomeEmployeesId,
                    income.DataDate,
                    income.TotalIncome,
                    income.ThucLinh);
            }
        }

        private void initDepartment()
        {
            Dictionary<int, string> dicDepartments = _context.Departments.OrderBy(x => x.ParentId).ToDictionary(x => x.DepartmentId, x => string.Format("{0} ({1})", x.DepartmentName, x.DepartmentId));
            cbxDepartment.DataSource = new BindingSource(dicDepartments, null);
            cbxDepartment.DisplayMember = "Value";
            cbxDepartment.ValueMember = "Key";
            dpkDataDate.Value = new DateTime(2022, 12, 10);
        }

        private void initData()
        {
            IEnumerable<ViewIncomeEmployee> incomes = getIncomeEmployees();
            setDataToGrid(incomes);
        }

        private IEnumerable<int> getChildDepartmentId(int parentDepartmentId = 0)
        {
            List<int> allId = new List<int>()
            {
                parentDepartmentId
            };

            List<int> lstChildDepartmentId = _context.Departments.Where(x => x.ParentId == parentDepartmentId).Select(x => x.DepartmentId).ToList();
            if (lstChildDepartmentId.Count() > 0)
            {
                foreach (int childDepartmentId in lstChildDepartmentId)
                {
                    allId.AddRange(getChildDepartmentId(childDepartmentId));
                }
            }
            return allId.Distinct();
        }

        private IEnumerable<ViewIncomeEmployee> getIncomeEmployees(IEnumerable<int> userIds = null)
        {
            int departmentId = 0;
            if (cbxDepartment.InvokeRequired)
            {
                cbxDepartment.Invoke(new MethodInvoker(delegate { departmentId = Convert.ToInt32(cbxDepartment.SelectedValue); }));
            }
            else
            {
                departmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
            }

            DateTime dataDate = dpkDataDate.Value.Date;
            IEnumerable<int> allDepartmentIds = getChildDepartmentId(departmentId);
            if (userIds != null)
            {

                return _context.ViewIncomeEmployees.Where(x => allDepartmentIds.Contains(x.DepartmentId) && x.DataDate == dataDate && userIds.Contains(x.UserId)).ToList();
            }
            return _context.ViewIncomeEmployees.Where(x => allDepartmentIds.Contains(x.DepartmentId) && x.DataDate == dataDate).ToList();
        }

        private void setTextTotal(int total)
        {
            lblTotal.Text = string.Format("Tổng số: {0}", total);
        }

        private IEnumerable<int> getUserIdSelected()
        {
            DataGridViewSelectedCellCollection selectedCells = dgvData.SelectedCells;

            for (int i = 0; i < selectedCells.Count; i++)
            {
                int rowIndex = selectedCells[i].RowIndex;
                int userId = Convert.ToInt16(dgvData.Rows[rowIndex].Cells[0].Value);
                if (userId != 0)
                {
                    yield return userId;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            IEnumerable<ViewIncomeEmployee> incomes = getIncomeEmployees();
            setDataToGrid(incomes);
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            _workerSendMail = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true,
            };
            _workerSendMail.DoWork += sendAllUser;
            _workerSendMail.ProgressChanged += updateProgress;
            _workerSendMail.RunWorkerCompleted += workerCompleted;
            _workerSendMail.RunWorkerAsync();
        }

        private void updateProgress(object sender, ProgressChangedEventArgs e)
        {
            prgBar.Value = e.ProgressPercentage;
            if (e.UserState != null)
            {
                try
                {
                    CounterState counter = (CounterState)e.UserState;
                    lblFail.Text = string.Format("Lỗi: {0}", counter.fail);
                    lblSuccess.Text = string.Format("Thành công: {0}", counter.success);
                }
                catch (Exception)
                {


                }
            }
        }


        private CounterState _counter = new CounterState()
        {
            fail = 0,
            success = 0,
            total = 0
        };

        //private int _success = 0;
        //private int _failure = 0;
        //private int _total = 0;
        private StringBuilder _message = new StringBuilder();
        private void resetCounter()
        {
            //_success = 0;
            //_failure = 0;
            //_total = 0;
            _counter.Reset();
            _message.Clear();
        }


        private void guiLuongUserChon(object sender, EventArgs e)
        {

            if (_workerSendMail != null && _workerSendMail.IsBusy)
            {
                MessageBox.Show("Vui lòng chờ tiến trình trước kết thúc");
            }

            _workerSendMail = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true,
            };
            _workerSendMail.DoWork += sendSpecificUser;
            _workerSendMail.ProgressChanged += updateProgress;
            _workerSendMail.RunWorkerCompleted += workerCompleted;
            _workerSendMail.RunWorkerAsync();
        }
        private void sendSpecificUser(object sender, DoWorkEventArgs e)
        {
            IEnumerable<int> selectedUserIds = getUserIdSelected();
            IEnumerable<ViewIncomeEmployee> incomes = getIncomeEmployees(selectedUserIds);
            sendMail(incomes);
        }

        private void sendAllUser(object sender, DoWorkEventArgs e)
        {
            IEnumerable<ViewIncomeEmployee> incomes = getIncomeEmployees();
            sendMail(incomes);
        }

        private string formatCurrency(decimal? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToString("C", new CultureInfo("vi-VN"));
            }
            return string.Empty;
        }

        private void sendMail(IEnumerable<ViewIncomeEmployee> incomes)
        {
            resetCounter();
            _counter.total = incomes.Count();
            if (prgBar.InvokeRequired)
            {
                prgBar.Invoke((MethodInvoker)delegate
                {
                    prgBar.Maximum = _counter.total;
                    prgBar.Value = 0;
                });
            }

            int port = _configuration.GetValue<int>("MailSettings:Port");
            string host = _configuration.GetValue<string>("MailSettings:Host");
            string sender_address = _configuration.GetValue<string>("MailSettings:SenderAddress");
            string sender_name = _configuration.GetValue<string>("MailSettings:SenderName");
            string password = _configuration.GetValue<string>("MailSettings:SenderSecret");

            MailAddress from = new MailAddress(sender_address, sender_name);

            List<Task> tasks = new List<Task>();


            string template = System.IO.File.ReadAllText(_configuration.GetValue<string>("MailSettings:Template"));
            if (!string.IsNullOrWhiteSpace(template))
            {

                string imageLogo =AppContext.BaseDirectory+ _configuration.GetValue<string>("MailSettings:SignatureLogo");
               
               

                foreach (var income in incomes)
                {
                    SmtpClient mailClient = new SmtpClient(host)
                    {
                        Port = port,
                        Credentials = new NetworkCredential(sender_address, password),
                        EnableSsl = true,
                    };

                    mailClient.SendCompleted += OnMailSendCompleted;
                    Employee em = _context.Employees.Find(income.UserId);
                    if (em != null && !string.IsNullOrWhiteSpace(em.BusinessEmail))
                    {
                        MailAddress to = new MailAddress(em.BusinessEmail);


                        string body = template;


                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.KiLuongThang), income.DataDate.ToString("MM/yyyy"), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.HoTen), income.FullName, RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.DonVi), income.DepartmentFullName, RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.MaNhanVien), em.UserName, RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.ChucVu), em.PositionName, RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.Email), em.BusinessEmail, RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.SoTaiKhoan), "0x000", RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.LuongCoBan), formatCurrency(income.LCB), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.PhuCapTrachNhiem), formatCurrency(income.PCTN), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.PhuCapThamNien), formatCurrency(income.PCTN), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.AnGiuaCa), formatCurrency(income.TienAnGiuaCa), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.TongTienThemGio), formatCurrency(income.TienThemGio), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.TienLamDem), formatCurrency(income.TienLamDem), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.BaoHiemXaHoi), formatCurrency(income.BHXH), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.BaoHiemYTe), formatCurrency(income.BHYT), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.BaoHiemThatNghiep), formatCurrency(income.BHTN), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.ThueThuNhap), formatCurrency(income.ThueThuNhap), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.DoanPhi), formatCurrency(income.DoanPhiCD), RegexOptions.None, TimeSpan.FromSeconds(5));
                        body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.ThucLinh), formatCurrency(income.ThucLinh), RegexOptions.None, TimeSpan.FromSeconds(5));

                        LinkedResource linkedResource = new LinkedResource(imageLogo, MediaTypeNames.Image.Jpeg);
                        linkedResource.ContentId = MailConst.Logo;
                        
                        AlternateView alternateView = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);
                        alternateView.LinkedResources.Add(linkedResource);

                        MailMessage message = new MailMessage(from, to)
                        {
                            Subject = string.Format("BẢNG KÊ CHI TRẢ LƯƠNG {0}", income.DataDate.ToString("MM/yyyy")),
                            //Body = body,
                            IsBodyHtml = true,
                            AlternateViews = { alternateView },
                        };
                        Task t = mailClient.SendMailAsync(message);
                        tasks.Add(t);
                    }
                    else
                    {
                        _counter.fail += 1;
                        _workerSendMail.ReportProgress(_counter.success + _counter.fail, _counter);
                        _message.AppendLine(string.Format("không tìm thấy userId[{0}] hoặc không có địa chỉ email", income.UserId));
                    }
                }
                try
                {
                    Task.WaitAll(tasks.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy template");
            }

        }

        private void OnMailSendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                _counter.fail += 1;
            }
            else
            {
                _counter.success += 1;
            }
            _workerSendMail.ReportProgress(_counter.success + _counter.fail, _counter);
        }

        private void workerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string message = _message.ToString();
            if (!string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(string.Format("Đã gửi thành công {0} mail", _counter.success), "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
