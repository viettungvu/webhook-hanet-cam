using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class DepartmentEmployee
    {
        public int DepartmentId { get; set; }
        public int UserId { get; set; }
        public Department Department { get; set; }
        public Employee Employee { get; set; }
    }
}
