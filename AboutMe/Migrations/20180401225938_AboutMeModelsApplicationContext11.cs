using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AboutMe.Migrations
{
    public partial class AboutMeModelsApplicationContext11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Appointments",
                newName: "toDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "fromDate",
                table: "Appointments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fromDate",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "toDate",
                table: "Appointments",
                newName: "Date");
        }
    }
}
