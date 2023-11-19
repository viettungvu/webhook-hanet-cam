using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormSendMail.Ext;
using Infra.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

        private void frmIncome_Load(object sender, EventArgs e)
        {

        }
        private void initGrid()
        {
            dgvData.AddColumn("UserId", "UserID");
            dgvData.AddColumn("Username", "Username");
            dgvData.AddColumn("Fullname", "Fullname");
            dgvData.AddColumn("BussinessEmail", "BussinessEmail");
            dgvData.AddColumn("PositionName", "PositionName");

        }
        private void initCbxPhongBan()
        {
            Dictionary<int, string> dicDepartments = _context.Departments.OrderBy(x => x.ParentId).ToDictionary(x => x.DepartmentId, x => string.Format("{0} ({1})", x.DepartmentName, x.DepartmentId));
            cbxDepartment.DataSource = new BindingSource(dicDepartments, null);
            cbxDepartment.DisplayMember = "Value";
            cbxDepartment.ValueMember = "Key";
        }
    }
}
