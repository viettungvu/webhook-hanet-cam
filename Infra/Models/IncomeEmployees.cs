using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class IncomeEmployees
    {
        public long IncomeEmployeesId { get; set; }
        public int UserId { get; set; }
        public decimal TienAnGiuaCa { get; set; }
        public decimal ThucLinh { get; set; }
    }
}
