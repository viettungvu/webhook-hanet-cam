using Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.EF
{
    public class HRMDbContext : DbContext
    {
        public HRMDbContext()
        {
        }

        public HRMDbContext(DbContextOptions<HRMDbContext> options)
               : base(options)
        {
        }
        public DbSet<CheckinData> CheckinData { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DepartmentEmployee> DepartmentEmployee { get; set; }
        public DbSet<IncomeEmployees> IncomeEmployess { get; set; }


        public DbSet<ViewIncomeEmployee> ViewIncomeEmployees { get; set; }
        public DbSet<ViewDepartmentEmployee> ViewDepartmentEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>()
               .ToTable("H0_Departments")
                 .HasKey(x => x.DepartmentId);

            modelBuilder.Entity<Employee>()
                .ToTable("Employees")
                 .HasKey(x => x.UserId);


            modelBuilder.Entity<DepartmentEmployee>()
                .ToTable("H0_DepartmentEmployee")
                .HasKey(de => new { de.DepartmentId, de.UserId });

            modelBuilder.Entity<DepartmentEmployee>()
               .HasOne<Department>(de => de.Department)
               .WithMany(d => d.DepartmentEmployees)
               .HasForeignKey(de => de.DepartmentId);

            modelBuilder.Entity<DepartmentEmployee>()
              .HasOne<Employee>(de => de.Employee)
              .WithMany(d => d.DepartmentEmployees)
              .HasForeignKey(de => de.UserId);

            modelBuilder.Entity<IncomeEmployees>()
                .ToTable("H1_IncomeEmployees")
                .HasKey(x => x.IncomeEmployeesId);


            modelBuilder.Entity<ViewIncomeEmployee>()
                .HasNoKey()
                .ToView("View_H1_IncomeEmployees");

            modelBuilder.Entity<ViewDepartmentEmployee>()
               .HasNoKey()
               .ToView("View_H0_DepartmentEmployee");


        }
    }

    public class SqliteDbContext : DbContext
    {
        public SqliteDbContext()
        {

        }
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        {

        }

        public DbSet<CheckinFail> CheckinData { get; set; }
    }
}
