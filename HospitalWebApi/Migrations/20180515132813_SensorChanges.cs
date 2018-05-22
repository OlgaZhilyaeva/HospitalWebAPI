using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HospitalWebApi.Migrations
{
    public partial class SensorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sensors_Temperatures_TemperatureId",
                table: "Sensors");

            migrationBuilder.DropIndex(
                name: "IX_Sensors_TemperatureId",
                table: "Sensors");

            migrationBuilder.DropColumn(
                name: "TemperatureId",
                table: "Sensors");

            migrationBuilder.AddColumn<int>(
                name: "SensorId",
                table: "Temperatures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Temperatures_SensorId",
                table: "Temperatures",
                column: "SensorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Temperatures_Sensors_SensorId",
                table: "Temperatures",
                column: "SensorId",
                principalTable: "Sensors",
                principalColumn: "SensorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Temperatures_Sensors_SensorId",
                table: "Temperatures");

            migrationBuilder.DropIndex(
                name: "IX_Temperatures_SensorId",
                table: "Temperatures");

            migrationBuilder.DropColumn(
                name: "SensorId",
                table: "Temperatures");

            migrationBuilder.AddColumn<int>(
                name: "TemperatureId",
                table: "Sensors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sensors_TemperatureId",
                table: "Sensors",
                column: "TemperatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sensors_Temperatures_TemperatureId",
                table: "Sensors",
                column: "TemperatureId",
                principalTable: "Temperatures",
                principalColumn: "TemperatureId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
