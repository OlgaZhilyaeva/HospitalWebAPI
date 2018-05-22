using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HospitalWebApi.Migrations
{
    public partial class AddlogicforUserSessionVariable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Temperatures_TemperatureId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_TemperatureId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TemperatureId",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Temperatures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Temperatures_PatientId",
                table: "Temperatures",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Temperatures_Patients_PatientId",
                table: "Temperatures",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Temperatures_Patients_PatientId",
                table: "Temperatures");

            migrationBuilder.DropIndex(
                name: "IX_Temperatures_PatientId",
                table: "Temperatures");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Temperatures");

            migrationBuilder.AddColumn<int>(
                name: "TemperatureId",
                table: "Patients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TemperatureId",
                table: "Patients",
                column: "TemperatureId",
                unique: true,
                filter: "[TemperatureId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Temperatures_TemperatureId",
                table: "Patients",
                column: "TemperatureId",
                principalTable: "Temperatures",
                principalColumn: "TemperatureId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
