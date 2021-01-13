using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalProject.Migrations
{
    public partial class Projekti1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateIn",
                value: new DateTime(2021, 1, 11, 13, 3, 18, 94, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateIn",
                value: new DateTime(2021, 1, 11, 13, 3, 18, 96, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateIn",
                value: new DateTime(2020, 1, 28, 14, 2, 15, 31, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateIn",
                value: new DateTime(2020, 1, 28, 14, 2, 15, 34, DateTimeKind.Local));
        }
    }
}
