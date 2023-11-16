using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class Employee
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? PositionName { get; set; }
        public string? BusinessEmail { get; set; }

        public virtual List<DepartmentEmployee> DepartmentEmployees { get; set; }
    }
}
