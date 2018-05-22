using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HospitalWebApi.Migrations
{
    public partial class LinkPatienswithtemperature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TemperatureId",
                table: "Patients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TemperatureId",
                table: "Patients",
                column: "TemperatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Temperatures_TemperatureId",
                table: "Patients",
                column: "TemperatureId",
                principalTable: "Temperatures",
                principalColumn: "TemperatureId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
