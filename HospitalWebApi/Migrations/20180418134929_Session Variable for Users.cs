using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HospitalWebApi.Migrations
{
    public partial class SessionVariableforUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patients_TemperatureId",
                table: "Patients");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TemperatureId",
                table: "Patients",
                column: "TemperatureId",
                unique: true,
                filter: "[TemperatureId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patients_TemperatureId",
                table: "Patients");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TemperatureId",
                table: "Patients",
                column: "TemperatureId");
        }
    }
}
