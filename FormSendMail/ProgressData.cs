using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSendMail
{
    public class CounterState
    {
        public int success { get; set; }
        public int fail { get; set; }
        public int total { get; set; }
        public void Reset()
        {
            success = 0;
            fail = 0;
            total = 0;
        }
    }
}
