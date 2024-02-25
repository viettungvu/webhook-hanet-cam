﻿// <auto-generated />
using System;
using Infra.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations.HRMDb
{
    [DbContext(typeof(HRMDbContext))]
    partial class HRMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Infra.Models.CheckinData", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("action_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aliasID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("detected_image_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deviceID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keycode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("temp")
                        .HasColumnType("int");

                    b.Property<long>("time")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("CheckinData");
                });

            modelBuilder.Entity("Infra.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.ToTable("H0_Departments", (string)null);
                });

            modelBuilder.Entity("Infra.Models.DepartmentEmployee", b =>
                {
                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("H0_DepartmentEmployee", (string)null);
                });

            modelBuilder.Entity("Infra.Models.Employee", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("BusinessEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("Infra.Models.IncomeEmployees", b =>
                {
                    b.Property<long>("IncomeEmployeesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IncomeEmployeesId"), 1L, 1);

                    b.Property<decimal>("ThucLinh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TienAnGiuaCa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("IncomeEmployeesId");

                    b.ToTable("H1_IncomeEmployees", (string)null);
                });

            modelBuilder.Entity("Infra.Models.MailLog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ErrorCount")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MailLogs", (string)null);
                });

            modelBuilder.Entity("Infra.Models.ViewDepartmentEmployee", b =>
                {
                    b.Property<string>("DepartmentFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("View_H0_DepartmentEmployee");
                });

            modelBuilder.Entity("Infra.Models.ViewIncomeEmployee", b =>
                {
                    b.Property<decimal?>("BHTN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BHXH")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BHYT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<decimal?>("DoanPhiCD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IncomeEmployeesId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("LCB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PCCV")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PCTN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ThucLinh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ThueThuNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TienAnGiuaCa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TienLamDem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TienThemGio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("View_H1_IncomeEmployees");
                });

            modelBuilder.Entity("Infra.Models.DepartmentEmployee", b =>
                {
                    b.HasOne("Infra.Models.Department", "Department")
                        .WithMany("DepartmentEmployees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infra.Models.Employee", "Employee")
                        .WithMany("DepartmentEmployees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Infra.Models.Department", b =>
                {
                    b.Navigation("DepartmentEmployees");
                });

            modelBuilder.Entity("Infra.Models.Employee", b =>
                {
                    b.Navigation("DepartmentEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}
