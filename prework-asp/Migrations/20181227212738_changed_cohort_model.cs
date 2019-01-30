using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace preworkasp.Migrations
{
    public partial class changed_cohort_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TclID",
                table: "Cohort");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TclID",
                table: "Cohort",
                nullable: false,
                defaultValue: 0);
        }
    }
}
