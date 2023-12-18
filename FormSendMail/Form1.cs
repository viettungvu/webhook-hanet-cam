using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using FormSendMail.Ext;
using Infra.EF;
using Infra.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace FormSendMail
{
    public partial class Form1 : Form
    {
        private readonly HRMDbContext _context;
        private readonly IConfiguration _configuration;
        public Form1(HRMDbContext context, IConfiguration config)
        {
            _context = context;
            _configuration = config;
            InitializeComponent();
        }


        #region private control
        private ContextMenuStrip menuContext;
        //private MenuStrip menuContext;
        #endregion

        private void initGrid()
        {
            dgvData.AddColumn("UserId", "UserID");
            dgvData.AddColumn("Username", "Username");
            dgvData.AddColumn("Fullname", "Fullname");
            dgvData.AddColumn("BussinessEmail", "BussinessEmail");
            dgvData.AddColumn("PositionName", "PositionName");
            dgvData.MouseUp += openMenuStrip;
        }

        private void initStrip()
        {
            menuContext = new ContextMenuStrip();
            ToolStripMenuItem tsGuiBangLuong = new ToolStripMenuItem()
            {
                Text = "Gủi bảng lương cho NV đã chọn",
                ShortcutKeys = Keys.F10,
            };
            tsGuiBangLuong.Click += guiBangLuong;
            //menuContext.Items.Add(tsGuiBangLuong);



            ToolStripMenuItem tsGuiAllNhanVien = new ToolStripMenuItem()
            {
                Text = "Gửi bảng lương cho tất cả NV",
                ShortcutKeys = Keys.F10,
            };
            tsGuiAllNhanVien.Click += guiBangLuongAllNhanVien;
            menuContext.Items.Add(tsGuiAllNhanVien);
        }

        private void openMenuStrip(object? sender, MouseEventArgs arg)
        {
            if (arg.Button == MouseButtons.Right)
            {
                menuContext.Show(Cursor.Position);
            }
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

        private void guiBangLuong(object? sender, EventArgs arg)
        {
            //MessageBox.Show("Click Right");
            IEnumerable<int> selectedUserIds = getUserIdSelected().Distinct();
            int port = _configuration.GetValue<int>("MailSettings:Port");
            string host = _configuration.GetValue<string>("MailSettings:Host");
            string sender_address = _configuration.GetValue<string>("MailSettings:SenderAddress");
            string sender_name = _configuration.GetValue<string>("MailSettings:SenderName");
            string password = _configuration.GetValue<string>("MailSettings:SenderSecret");
            SmtpClient mailClient = new SmtpClient(host)
            {
                Port = port,
                Credentials = new NetworkCredential(sender_address, password),
                EnableSsl = true,
            };

            mailClient.SendCompleted += OnMailSendCompleted;
            MailAddress from = new MailAddress(sender_address, sender_name);

            List<Task> tasks = new List<Task>();
            foreach (int userId in selectedUserIds)
            {
                Employee? em = _context.Employees.Find(userId);
                if (em != null && !string.IsNullOrWhiteSpace(em.BusinessEmail))
                {
                    em.BusinessEmail = "tungvv@xmedia.vn";
                    List<IncomeEmployees> incomes = _context.IncomeEmployess.Where(x => x.UserId == userId).ToList();
                    MailAddress to = new MailAddress(em.BusinessEmail);
                    MailMessage message = new MailMessage(from, to)
                    {
                        Body = JsonSerializer.Serialize(incomes),
                        IsBodyHtml = true,
                        Subject = "Luong thang 11 -- test",
                    };
                    Task t = mailClient.SendMailAsync(message);
                    tasks.Add(t);
                }
            }
            Task promise = Task.WhenAll(tasks);
            try
            {
                promise.Wait();
                MessageBox.Show("Hoàn thành");
            }
            catch (Exception)
            {


            }
        }



        BackgroundWorker workerSendMail;
        private void guiBangLuongAllNhanVien(object? sender, EventArgs arg)
        {
            workerSendMail = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
            };
            workerSendMail.DoWork += sendMailAll;
            workerSendMail.ProgressChanged += updateSendMailProgress;
            workerSendMail.RunWorkerAsync();
        }

        private void updateSendMailProgress(object? sender, ProgressChangedEventArgs e)
        {
            string message = Convert.ToString(e.UserState);
            if (!string.IsNullOrWhiteSpace(message))
            {
                txtTerminal.AppendText(message + "\n");
            }
        }

        private void sendMailAll(object? sender, DoWorkEventArgs e)
        {
            int departmentId = -1;
            if (cbxPhongBan.InvokeRequired)
            {
                cbxPhongBan.Invoke(new MethodInvoker(delegate { departmentId = Convert.ToInt32(cbxPhongBan.SelectedValue); }));
            }
            IEnumerable<Employee> employees = getEmployees(departmentId).Where(x => !string.IsNullOrEmpty(x.BusinessEmail));
            if (employees.Any())
            {
                workerSendMail.ReportProgress(0, formatMessage("Đang đọc config"));
                int port = _configuration.GetValue<int>("MailSettings:Port");
                string host = _configuration.GetValue<string>("MailSettings:Host");
                string sender_address = _configuration.GetValue<string>("MailSettings:SenderAddress");
                string sender_name = _configuration.GetValue<string>("MailSettings:SenderName");
                string password = _configuration.GetValue<string>("MailSettings:SenderSecret");

                workerSendMail.ReportProgress(0, formatMessage("Bắt đầu gửi mail"));
                SmtpClient mailClient = new SmtpClient(host)
                {
                    Port = port,
                    Credentials = new NetworkCredential(sender_address, password),
                    EnableSsl = true,
                };

                mailClient.SendCompleted += OnMailSendCompleted;
                MailAddress from = new MailAddress(sender_address, sender_name);

                List<Task> tasks = new List<Task>();
                foreach (var em in employees)
                {
                    var emIncomes = _context.IncomeEmployess.Where(x => x.UserId == em.UserId);
                    if (emIncomes.Any())
                    {
                        MailAddress to = new MailAddress(em.BusinessEmail);
                        MailMessage message = new MailMessage(from, to)
                        {
                            Body = JsonSerializer.Serialize(emIncomes),
                            IsBodyHtml = true,
                            Subject = string.Format("Bang Luong nhan vien - {0}", em.FullName),
                        };
                        Task t = mailClient.SendMailAsync(message);
                        tasks.Add(t);
                        workerSendMail.ReportProgress(0, formatMessage(string.Format("Đang gửi cho {0}", em.BusinessEmail)));
                    }
                    else
                    {
                        workerSendMail.ReportProgress(0, formatMessage(string.Format("Không thấy dữ liệu lương của {0}", em.UserName)));
                    }

                }
                Task tAll = Task.WhenAll(tasks.ToArray());
                try
                {
                    tAll.Wait();

                    workerSendMail.ReportProgress(100, formatMessage("Hoàn tất gửi mail"));

                }
                catch (Exception ex)
                {

                    workerSendMail.ReportProgress(100, formatMessage(ex.Message));
                }
            }
            else
            {
                workerSendMail.ReportProgress(0, formatMessage("Không có dữ liệu"));
            }
        }

        private string formatMessage(string message)
        {
            return string.Format("[{0}]: {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), message);
        }

        private void OnMailSendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }

        private void initControl()
        {
            initCbxPhongBan();
            initGrid();
            initStrip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initControl();
        }

        private void initCbxPhongBan()
        {
            Dictionary<int, string> dicDepartments = _context.Departments.OrderBy(x => x.ParentId).ToDictionary(x => x.DepartmentId, x => string.Format("{0} ({1})", x.DepartmentName, x.DepartmentId));
            cbxPhongBan.DataSource = new BindingSource(dicDepartments, null);
            cbxPhongBan.DisplayMember = "Value";
            cbxPhongBan.ValueMember = "Key";
        }

        private void addDataToGrid(IEnumerable<Employee> employees)
        {
            if (employees != null)
            {
                foreach (var em in employees)
                {
                    dgvData.Rows.Add(em.UserId, em.UserName, em.FullName, em.BusinessEmail, em.PositionName);
                }
                lblTotal.Text = string.Format("Tổng số: {0}", employees.Count());
            }
        }

        private IEnumerable<Employee> getEmployees(int departmentId)
        {
            IEnumerable<int> userIds = _context.DepartmentEmployee.Where(x => x.DepartmentId == departmentId).Select(x => x.UserId);
            return _context.Employees.Where(x => userIds.Contains(x.UserId)).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int departmentId = Convert.ToInt32(cbxPhongBan.SelectedValue);
            IEnumerable<Employee> employees = getEmployees(departmentId);
            addDataToGrid(employees);
        }



    }
}