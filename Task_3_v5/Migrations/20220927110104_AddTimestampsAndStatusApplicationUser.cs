using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_3_v5.Migrations
{
    public partial class AddTimestampsAndStatusApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 13, 1, 4, 386, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "active");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLoginTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegistrationTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");
        }
    }
}
