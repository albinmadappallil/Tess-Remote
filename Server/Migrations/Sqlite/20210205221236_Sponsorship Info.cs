﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Tess.Server.Migrations.Sqlite
{
    public partial class SponsorshipInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GithubUser",
                table: "Organizations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelayCode",
                table: "Organizations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnlockCode",
                table: "Organizations",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GithubUser",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "RelayCode",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "UnlockCode",
                table: "Organizations");
        }
    }
}
