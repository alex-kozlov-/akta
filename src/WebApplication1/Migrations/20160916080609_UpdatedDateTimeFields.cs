using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class UpdatedDateTimeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Bicycles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedDate",
                table: "Bicycles",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Bicycles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Bicycles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedDate",
                table: "Bicycles",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Bicycles",
                nullable: false);
        }
    }
}
