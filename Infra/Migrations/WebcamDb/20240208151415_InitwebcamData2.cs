using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations.WebcamDb
{
    public partial class InitwebcamData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6401), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6412), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6414), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6414), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6417), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6422), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6424), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6424), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6426), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6428), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6429), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6430), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6433), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6434), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6435), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6435), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6437), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6439), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6440), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6441), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6441), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6444), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6445), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6447), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6448), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6449), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6452), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6453), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6454), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6454), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6457), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6457), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6461), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6463), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6464), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6466), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6467), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6468), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6468), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6469), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6470), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6471), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6472), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6473), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6474), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6476), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6477), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6478), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6479), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6479), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6481), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6481), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6482), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6483), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6484), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6485), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6486), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6495), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6495), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6496), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6498), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6499), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6501), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6501), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6503), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6503), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6504), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6505), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6506), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6507), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6509), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6509), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6510), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6512), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6513), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6514), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6514), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6515), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6517), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6519), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6520), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6521), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6522), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6523), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6524), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6527), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6528), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6530), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6531), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6532), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6535), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6537), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6537), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6538), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6540), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6542), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6543), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6545), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6548), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6550), 5674 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 2, 8, 22, 14, 15, 465, DateTimeKind.Local).AddTicks(6551) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9292), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9303), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9305), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9306), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9311), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9313), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9315), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9316), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9318), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9320), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9320), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9321), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9322), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9323), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9323), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9324), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9325), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9326), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9326), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9327), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9334), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9335), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9336), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9339), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9340), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9342), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9343), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9345), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9346), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9347), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9347), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9348), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9349), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9349), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9350), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9351), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9353), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9355), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9356), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9359), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9359), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9360), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9363), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9364), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9367), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9367), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9368), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9370), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9370), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9371), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9372), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9374), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9377), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9377), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9378), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9379), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9381), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9382), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9382), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9383), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9384), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9385), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9385), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9386), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AuthDate", "AuthDateTime", "UserID" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9387), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5677 });

            migrationBuilder.UpdateData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AuthDate", "AuthDateTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9387), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
