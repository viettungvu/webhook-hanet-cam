using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class MailLog
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int UserId { get; set; }
        public string Email { get; set; }
        public DateTime DataDate { get; set; }
        public int ErrorCount { get; set; }
        public MailSendStatus Status { get; set; } = MailSendStatus.FAILED;
    }
   
}
