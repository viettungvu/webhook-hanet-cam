using Infra.Models;
using Infra.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF
{
    public class WebcamDbContext : DbContext
    {
        public WebcamDbContext()
        {

        }
        public WebcamDbContext(DbContextOptions<WebcamDbContext> options) : base(options)
        {

           
        }

        public DbSet<Attendance> Attendance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
              .ToTable("Attendance_Log")
                .HasKey(x => x.Id);

            DbSeedData.SeedWebCamData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
