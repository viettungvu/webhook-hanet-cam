using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int Flag { get; set; }
        public string DeviceName { get; set; }
        public string DeviceNo { get; set; }
        public DateTime AuthDateTime { get; set; }
        public DateTime AuthDate { get; set; }
        public DateTime AuthTime { get; set; }
    }

    public class AttendanceMap 
    {
        public int UserID { get; set; }
        public int Flag { get; set; }
        public string DeviceName { get; set; }
        public DateTime AuthDateTime { get; set; }
    }

}
