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
using Newtonsoft.Json.Linq;
using System.Threading.Tasks.Dataflow;

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

        List<Task> tasks = new List<Task>();
        Dictionary<int, MailLog> _mailLog = new Dictionary<int, MailLog>();


        private void sendMail(IEnumerable<ViewIncomeEmployee> incomes)
        {
            _mailLog.Clear();
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
            string template = System.IO.File.ReadAllText(_configuration.GetValue<string>("MailSettings:Template"));
            if (!string.IsNullOrWhiteSpace(template))
            {

                string imageLogo = AppContext.BaseDirectory + _configuration.GetValue<string>("MailSettings:SignatureLogo");



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
                        body += footer;
                        LinkedResource linkedResource = new LinkedResource(imageLogo, MediaTypeNames.Image.Jpeg);
                        linkedResource.ContentId = MailConst.Logo;

                        AlternateView alternateView = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);
                        alternateView.LinkedResources.Add(linkedResource);

                        MailMessage message = new MailMessage(from, to)
                        {
                            Subject = string.Format("BẢNG KÊ CHI TRẢ LƯƠNG {0}", income.DataDate.ToString("MM/yyyy")),
                            Body = body,
                            IsBodyHtml = true,
                            AlternateViews = { alternateView },
                        };
                        Task t = mailClient.SendMailAsync(message);
                        tasks.Add(t);

                        _mailLog.Add(t.Id, new MailLog
                        {
                            DataDate = income.DataDate,
                            UserId = income.UserId,
                            Email = em.BusinessEmail,
                        });
                        Thread.Sleep(1000);
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
            try
            {
                JObject state = JObject.Parse(e.UserState.ToString());
                if (int.TryParse(Convert.ToString(state["Id"]), out int taskId) && _mailLog.ContainsKey(taskId))
                {
                    _mailLog[taskId].Status = e.Error != null ? MailSendStatus.SUCCESSED : MailSendStatus.FAILED;
                    if (_mailLog[taskId].Status == MailSendStatus.FAILED)
                    {
                        _mailLog[taskId].ErrorCount += 1;
                    }
                }
            }
            catch (Exception)
            {


            }

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
            if (_mailLog.Count > 0)
            {
                _context.MailLogs.AddRange(_mailLog.Values);
                _context.SaveChanges();
                frmViewMailLog frmMailLog = new frmViewMailLog(_context, _configuration);
                frmMailLog.Ids = _mailLog.Values.Select(x => x.Id);
                frmMailLog.Show();

            }
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

        private static string footer = "<table style=\"border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;min-width: 320px;Margin: 0 auto;background-color: #e7e7e7;width:100%\" cellpadding=\"0\" cellspacing=\"0\">\r\n  <tbody>\r\n  <tr style=\"vertical-align: top\">\r\n    <td style=\"word-break: break-word;border-collapse: collapse !important;vertical-align: top\">\r\n    <!--[if (mso)|(IE)]><table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\"><tr><td align=\"center\" style=\"background-color: #e7e7e7;\"><![endif]-->\r\n    \r\n  \r\n  \r\n<div class=\"u-row-container\" style=\"padding: 0px;background-color: transparent\">\r\n  <div class=\"u-row\" style=\"margin: 0 auto;min-width: 320px;max-width: 500px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;\">\r\n    <div style=\"border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;\">\r\n      <!--[if (mso)|(IE)]><table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\"><tr><td style=\"padding: 0px;background-color: transparent;\" align=\"center\"><table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" style=\"width:500px;\"><tr style=\"background-color: transparent;\"><![endif]-->\r\n      \r\n<!--[if (mso)|(IE)]><td align=\"center\" width=\"500\" style=\"width: 500px;padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;\" valign=\"top\"><![endif]-->\r\n<div class=\"u-col u-col-100\" style=\"max-width: 320px;min-width: 500px;display: table-cell;vertical-align: top;\">\r\n  <div style=\"height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;\">\r\n  <!--[if (!mso)&(!IE)]><!--><div style=\"box-sizing: border-box; height: 100%; padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;\"><!--<![endif]-->\r\n  \r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n  <div style=\"font-size: 14px; line-height: 140%; text-align: left; word-wrap: break-word;\">\r\n    <p style=\"line-height: 140%;\">NGUYEN CHAU THANH HAU (MR.)<br />IT-Software<br />Planning &amp; IT Division<br />Cell: 84-792 723 651<br />Email: haunguyen.08061999@gmail.com</p>\r\n  </div>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n  <table height=\"0px\" align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;border-top: 1px solid #BBBBBB;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%\">\r\n    <tbody>\r\n      <tr style=\"vertical-align: top\">\r\n        <td style=\"word-break: break-word;border-collapse: collapse !important;vertical-align: top;font-size: 0px;line-height: 0px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%\">\r\n          <span>&#160;</span>\r\n        </td>\r\n      </tr>\r\n    </tbody>\r\n  </table>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n<table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">\r\n  <tr>\r\n    <td style=\"padding-right: 0px;padding-left: 0px;\" align=\"center\">\r\n      \r\n      <img align=\"center\" border=\"0\" src=\"cid:[SIGNATURE_LOGO]\" alt=\"\" title=\"\" style=\"outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: inline-block !important;border: none;height: auto;float: none;width: 100%;max-width: 480px;\" width=\"480\"/>\r\n      \r\n    </td>\r\n  </tr>\r\n</table>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n  <div style=\"font-size: 14px; line-height: 140%; text-align: left; word-wrap: break-word;\">\r\n    <p style=\"line-height: 140%;\">This email and any fi­les transmitted with it are con­dential and intended solely for the use of the individual or entity to whom they are addressed. If you have received this email in error, please notify the system manager.<br />Please note that any views or opinions presented in this email are solely those of the author and do not necessarily represent those of SAIGON GROUND SERVICES JSC. Finally, the recipient should check this email and any attachments for the presence of viruses. SAIGON GROUND SERVICES JSC accepts no liability for any damage caused by any virus transmitted by this email. Thank you!<br />PLEASE CONSIDER THE ENVIRONMENT BEFORE PRINTING THIS EMAIL.</p>\r\n  </div>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->\r\n  </div>\r\n</div>\r\n<!--[if (mso)|(IE)]></td><![endif]-->\r\n      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->\r\n    </div>\r\n  </div>\r\n  </div>\r\n  \r\n\r\n\r\n    <!--[if (mso)|(IE)]></td></tr></table><![endif]-->\r\n    </td>\r\n  </tr>\r\n  </tbody>\r\n  </table>";

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            //_context.MailLogs.Add(new MailLog
            //{
            //    UserId = 5674,
            //    Email = "tungvv@xmedia.vn",
            //    Status = MailSendStatus.FAILED,
            //    DataDate = dpkDataDate.Value,
            //});
            //_context.SaveChanges();
            frmViewMailLog frmMailLog = new frmViewMailLog(_context, _configuration);
            frmMailLog.DataDate = dpkDataDate.Value.Date;
            frmMailLog.Show();
        }
    }
}
