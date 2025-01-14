﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Tess.Server.Migrations.PostgreSql
{
    public partial class AddAlertDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Alerts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Alerts");
        }
    }
}
