using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations.WebcamDb
{
    public partial class InitAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendance_Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Flag = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance_Log", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Attendance_Log",
                columns: new[] { "Id", "AuthDate", "AuthDateTime", "AuthTime", "DeviceName", "DeviceNo", "Flag", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8458), "Webcam EZVIZ", null, 0, 5673 },
                    { 2, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8462), "Webcam EZVIZ", null, 0, 5676 },
                    { 3, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8470), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8470), "Webcam EZVIZ", null, 0, 5670 },
                    { 4, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8472), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8473), "Webcam EZVIZ", null, 0, 5672 },
                    { 5, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8474), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8474), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8475), "Webcam EZVIZ", null, 0, 5678 },
                    { 6, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8478), "Webcam EZVIZ", null, 0, 5675 },
                    { 7, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8481), "Webcam EZVIZ", null, 0, 5671 },
                    { 8, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8482), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8483), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8483), "Webcam EZVIZ", null, 0, 5672 },
                    { 9, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8485), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8485), "Webcam EZVIZ", null, 0, 5674 },
                    { 10, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8487), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8488), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8488), "Webcam EZVIZ", null, 0, 5679 },
                    { 11, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8489), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8491), "Webcam EZVIZ", null, 0, 5673 },
                    { 12, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8492), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8492), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8493), "Webcam EZVIZ", null, 0, 5677 },
                    { 13, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8495), "Webcam EZVIZ", null, 0, 5679 },
                    { 14, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8496), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8497), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8497), "Webcam EZVIZ", null, 0, 5675 },
                    { 15, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8500), "Webcam EZVIZ", null, 0, 5679 },
                    { 16, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8501), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8501), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8502), "Webcam EZVIZ", null, 0, 5671 },
                    { 17, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8504), "Webcam EZVIZ", null, 0, 5678 },
                    { 18, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8506), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8506), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8507), "Webcam EZVIZ", null, 0, 5672 },
                    { 19, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8508), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8509), "Webcam EZVIZ", null, 0, 5675 },
                    { 20, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8511), "Webcam EZVIZ", null, 0, 5670 },
                    { 21, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8513), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8513), "Webcam EZVIZ", null, 0, 5678 },
                    { 22, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8516), "Webcam EZVIZ", null, 0, 5672 },
                    { 23, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8517), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8517), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8518), "Webcam EZVIZ", null, 0, 5674 },
                    { 24, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8520), "Webcam EZVIZ", null, 0, 5675 },
                    { 25, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8522), "Webcam EZVIZ", null, 0, 5677 },
                    { 26, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8524), "Webcam EZVIZ", null, 0, 5670 },
                    { 27, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8525), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8526), "Webcam EZVIZ", null, 0, 5679 },
                    { 28, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8528), "Webcam EZVIZ", null, 0, 5671 },
                    { 29, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8530), "Webcam EZVIZ", null, 0, 5672 },
                    { 30, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8531), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8532), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8532), "Webcam EZVIZ", null, 0, 5673 },
                    { 31, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8533), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8534), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8534), "Webcam EZVIZ", null, 0, 5672 },
                    { 32, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8536), "Webcam EZVIZ", null, 0, 5674 },
                    { 33, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8537), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8538), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8538), "Webcam EZVIZ", null, 0, 5672 },
                    { 34, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8541), "Webcam EZVIZ", null, 0, 5674 },
                    { 35, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8542), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8543), "Webcam EZVIZ", null, 0, 5679 },
                    { 36, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8544), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8544), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8545), "Webcam EZVIZ", null, 0, 5679 },
                    { 37, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8546), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8547), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8547), "Webcam EZVIZ", null, 0, 5670 },
                    { 38, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8549), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8549), "Webcam EZVIZ", null, 0, 5676 },
                    { 39, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8551), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8551), "Webcam EZVIZ", null, 0, 5676 },
                    { 40, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8552), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8553), "Webcam EZVIZ", null, 0, 5674 },
                    { 41, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8555), "Webcam EZVIZ", null, 0, 5679 },
                    { 42, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8556), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8557), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8557), "Webcam EZVIZ", null, 0, 5672 }
                });

            migrationBuilder.InsertData(
                table: "Attendance_Log",
                columns: new[] { "Id", "AuthDate", "AuthDateTime", "AuthTime", "DeviceName", "DeviceNo", "Flag", "UserID" },
                values: new object[,]
                {
                    { 43, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8558), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8559), "Webcam EZVIZ", null, 0, 5672 },
                    { 44, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8561), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8561), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8562), "Webcam EZVIZ", null, 0, 5679 },
                    { 45, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8564), "Webcam EZVIZ", null, 0, 5674 },
                    { 46, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8566), "Webcam EZVIZ", null, 0, 5673 },
                    { 47, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8568), "Webcam EZVIZ", null, 0, 5678 },
                    { 48, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8570), "Webcam EZVIZ", null, 0, 5673 },
                    { 49, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8571), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8571), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8572), "Webcam EZVIZ", null, 0, 5670 },
                    { 50, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8573), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8573), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8574), "Webcam EZVIZ", null, 0, 5670 },
                    { 51, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8575), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8576), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8576), "Webcam EZVIZ", null, 0, 5675 },
                    { 52, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8577), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8578), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8578), "Webcam EZVIZ", null, 0, 5679 },
                    { 53, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8580), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8580), "Webcam EZVIZ", null, 0, 5671 },
                    { 54, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8582), "Webcam EZVIZ", null, 0, 5678 },
                    { 55, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8583), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8584), "Webcam EZVIZ", null, 0, 5677 },
                    { 56, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8587), "Webcam EZVIZ", null, 0, 5673 },
                    { 57, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8587), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8588), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8589), "Webcam EZVIZ", null, 0, 5674 },
                    { 58, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8591), "Webcam EZVIZ", null, 0, 5674 },
                    { 59, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8593), "Webcam EZVIZ", null, 0, 5670 },
                    { 60, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8595), "Webcam EZVIZ", null, 0, 5676 },
                    { 61, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8597), "Webcam EZVIZ", null, 0, 5673 },
                    { 62, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8599), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8599), "Webcam EZVIZ", null, 0, 5675 },
                    { 63, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8601), "Webcam EZVIZ", null, 0, 5673 },
                    { 64, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8603), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8603), "Webcam EZVIZ", null, 0, 5678 },
                    { 65, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8605), "Webcam EZVIZ", null, 0, 5678 },
                    { 66, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8607), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8608), "Webcam EZVIZ", null, 0, 5670 },
                    { 67, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8609), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8610), "Webcam EZVIZ", null, 0, 5676 },
                    { 68, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8611), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8612), "Webcam EZVIZ", null, 0, 5673 },
                    { 69, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8615), "Webcam EZVIZ", null, 0, 5671 },
                    { 70, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8616), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8617), "Webcam EZVIZ", null, 0, 5670 },
                    { 71, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8617), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8619), "Webcam EZVIZ", null, 0, 5670 },
                    { 72, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8621), "Webcam EZVIZ", null, 0, 5670 },
                    { 73, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8622), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8623), "Webcam EZVIZ", null, 0, 5676 },
                    { 74, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8625), "Webcam EZVIZ", null, 0, 5672 },
                    { 75, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8627), "Webcam EZVIZ", null, 0, 5677 },
                    { 76, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8629), "Webcam EZVIZ", null, 0, 5677 },
                    { 77, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8631), "Webcam EZVIZ", null, 0, 5678 },
                    { 78, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8633), "Webcam EZVIZ", null, 0, 5674 },
                    { 79, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8635), "Webcam EZVIZ", null, 0, 5679 },
                    { 80, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8637), "Webcam EZVIZ", null, 0, 5678 },
                    { 81, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8639), "Webcam EZVIZ", null, 0, 5679 },
                    { 82, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8641), "Webcam EZVIZ", null, 0, 5673 },
                    { 83, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8643), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8643), "Webcam EZVIZ", null, 0, 5674 },
                    { 84, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8644), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8645), "Webcam EZVIZ", null, 0, 5671 }
                });

            migrationBuilder.InsertData(
                table: "Attendance_Log",
                columns: new[] { "Id", "AuthDate", "AuthDateTime", "AuthTime", "DeviceName", "DeviceNo", "Flag", "UserID" },
                values: new object[,]
                {
                    { 85, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8647), "Webcam EZVIZ", null, 0, 5679 },
                    { 86, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8649), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8649), "Webcam EZVIZ", null, 0, 5674 },
                    { 87, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8656), "Webcam EZVIZ", null, 0, 5676 },
                    { 88, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8658), "Webcam EZVIZ", null, 0, 5679 },
                    { 89, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8660), "Webcam EZVIZ", null, 0, 5672 },
                    { 90, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8662), "Webcam EZVIZ", null, 0, 5677 },
                    { 91, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8664), "Webcam EZVIZ", null, 0, 5673 },
                    { 92, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8666), "Webcam EZVIZ", null, 0, 5677 },
                    { 93, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8667), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8668), "Webcam EZVIZ", null, 0, 5673 },
                    { 94, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8669), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8670), "Webcam EZVIZ", null, 0, 5679 },
                    { 95, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8672), "Webcam EZVIZ", null, 0, 5674 },
                    { 96, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8673), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8674), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8674), "Webcam EZVIZ", null, 0, 5675 },
                    { 97, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8675), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8676), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8676), "Webcam EZVIZ", null, 0, 5673 },
                    { 98, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8677), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8678), "Webcam EZVIZ", null, 0, 5675 },
                    { 99, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8679), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8680), "Webcam EZVIZ", null, 0, 5675 },
                    { 100, new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 2, 15, 20, 5, 9, 885, DateTimeKind.Local).AddTicks(8682), "Webcam EZVIZ", null, 0, 5674 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendance_Log");
        }
    }
}
