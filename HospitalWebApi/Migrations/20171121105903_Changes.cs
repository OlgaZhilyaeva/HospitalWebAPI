using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HospitalWebApi.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Doctors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PrescriptionId",
                table: "Doctors",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Prescriptions_PrescriptionId",
                table: "Doctors",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "PrescriptionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Prescriptions_PrescriptionId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_PrescriptionId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Doctors");
        }
    }
}
