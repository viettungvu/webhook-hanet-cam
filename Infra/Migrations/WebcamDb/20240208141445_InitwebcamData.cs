using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations.WebcamDb
{
    public partial class InitwebcamData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "Id", "AuthDate", "AuthDateTime", "AuthTime", "DeviceName", "DeviceNo", "Flag", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9292), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5674 },
                    { 2, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9303), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 3, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 4, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9305), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 5, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9306), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 6, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 7, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 8, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 9, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9311), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 10, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9313), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 11, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 12, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 13, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9315), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 14, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9316), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 15, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 16, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 17, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9318), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 18, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9320), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 19, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9320), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 20, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9321), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 21, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9322), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 22, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9323), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 23, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9323), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 24, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9324), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 25, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9325), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 26, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9326), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 27, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9326), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 28, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9327), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 29, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9334), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 30, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9335), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 31, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9336), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 32, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 33, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 34, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9339), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 35, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9340), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 36, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 37, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 38, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9342), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 39, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9343), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 40, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 41, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 42, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9345), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 }
                });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "Id", "AuthDate", "AuthDateTime", "AuthTime", "DeviceName", "DeviceNo", "Flag", "UserID" },
                values: new object[,]
                {
                    { 43, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9346), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 44, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9347), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 45, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9347), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 46, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9348), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 47, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9349), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 48, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9349), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 49, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9350), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 50, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9351), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 51, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 52, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 53, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9353), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 54, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 55, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 56, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9355), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 57, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9356), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 58, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 59, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 60, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 61, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9359), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 62, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9359), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 63, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9360), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 64, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 65, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 66, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9363), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 67, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9364), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 68, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 69, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 70, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 71, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9367), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 72, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9367), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 73, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9368), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 74, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 75, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9370), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 76, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9370), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 77, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9371), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 78, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9372), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 79, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 80, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 81, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9374), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 82, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 83, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 84, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 }
                });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "Id", "AuthDate", "AuthDateTime", "AuthTime", "DeviceName", "DeviceNo", "Flag", "UserID" },
                values: new object[,]
                {
                    { 85, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9377), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 86, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9377), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 87, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9378), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 88, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9379), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 89, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 90, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 91, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9381), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 92, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9382), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 93, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9382), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 94, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9383), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 95, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9384), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 96, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9385), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 97, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9385), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 98, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9386), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 },
                    { 99, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9387), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 0, 5677 },
                    { 100, new DateTime(2024, 2, 8, 21, 14, 45, 298, DateTimeKind.Local).AddTicks(9387), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webcam EZVIZ", null, 1, 5677 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
