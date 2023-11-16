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
            ToolStripMenuItem tsGuiBangLuong = new ToolStripMenuItem()
            {
                Text = "Gủi bảng lương qua email",
                ShortcutKeys = Keys.F10,

            };
            tsGuiBangLuong.Click += guiBangLuong;
            menuContext = new ContextMenuStrip();
            menuContext.Items.Add(tsGuiBangLuong);
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
                em.BusinessEmail = "tungvv@xmedia.vn";
                if (em != null && !string.IsNullOrWhiteSpace(em.BusinessEmail))
                {
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