using Infra.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Shared
{
    public static class DbSeedData
    {

        static Random _rd = new Random();
        public static void SeedWebCamData(ModelBuilder modelBuilder)
        {
            List<Attendance> attendances = new List<Attendance>();
            for (int i = 0; i < 100; i++)
            {
                attendances.Add(new Attendance
                {
                    Id = i + 1,
                    Flag = _rd.Next(0, 2),
                    UserID = _rd.Next(5670, 5680),
                    DeviceName = "Webcam EZVIZ",
                    AuthDate = DateTime.Now,
                    AuthDateTime = DateTime.Now,
                    AuthTime = DateTime.Now,
                });
            }

            modelBuilder.Entity<Attendance>()
                .HasData(attendances);
        }
    }
}
