using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class ViewIncomeEmployee
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        //public string DepartmentName { get; set; }
        public string? DepartmentFullName { get; set; }
        public int DepartmentId { get; set; }
        public long IncomeEmployeesId { get; set; }
        public DateTime DataDate { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? ThucLinh { get; set; }
        public decimal? ThucLinhLCB { get; set; }
        public decimal? LCB { get; set; }
        public decimal? PCCV { get; set; }
        public decimal? PCTN { get; set; }
        public decimal? TienAnGiuaCa { get; set; }
        public decimal? TienThemGio { get; set; }
        public decimal? TienLamDem { get; set; }
        public decimal? BHXH { get; set; }
        public decimal? BHYT { get; set; }
        public decimal? BHTN { get; set; }
        public decimal? ThueThuNhap { get; set; }
        public decimal? DoanPhiCD { get; set; }
        public decimal? Tong
        {
            get
            {
                return ThucLinh + ThucLinhLCB;
            }
        }
    }

    public class ViewDepartmentEmployee
    {
        public int DepartmentId { get; set; }
        public string DepartmentFullName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
    }
}
