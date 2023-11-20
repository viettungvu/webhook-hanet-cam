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
