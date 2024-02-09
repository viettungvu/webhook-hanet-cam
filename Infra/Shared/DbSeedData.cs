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
        public static void SeedWebCamData(ModelBuilder modelBuilder)
        {
            List<Attendance> attendances = new List<Attendance>();
            for (int i = 0; i < 100; i++)
            {
                attendances.Add(new Attendance
                {
                    Id = i + 1,
                    Flag = i % 2,
                    UserID = i % 2 == 0 ? 5674 : 5677,
                    DeviceName = "Webcam EZVIZ",
                    AuthDate = DateTime.Now,
                    AuthDateTime = DateTime.Now,
                });
            }

            modelBuilder.Entity<Attendance>()
                .HasData(attendances);
        }
    }
}
