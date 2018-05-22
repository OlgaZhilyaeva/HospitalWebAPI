using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HospitalWebApi.Migrations
{
    public partial class PatientChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Prescriptions_PrescriptionId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sensors_Patients_PatientId",
                table: "Sensors");

            migrationBuilder.DropIndex(
                name: "IX_Sensors_PatientId",
                table: "Sensors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_PrescriptionId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Sensors");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Prescriptions",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_DoctorId");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SensorId",
                table: "Patients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PrescriptionId",
                table: "Patients",
                column: "PrescriptionId",
                unique: true,
                filter: "[PrescriptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SensorId",
                table: "Patients",
                column: "SensorId",
                unique: true,
                filter: "[SensorId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Prescriptions_PrescriptionId",
                table: "Patients",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "PrescriptionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Sensors_SensorId",
                table: "Patients",
                column: "SensorId",
                principalTable: "Sensors",
                principalColumn: "SensorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Prescriptions_PrescriptionId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Sensors_SensorId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PrescriptionId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_SensorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SensorId",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Prescriptions",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_PatientId");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Sensors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Doctors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sensors_PatientId",
                table: "Sensors",
                column: "PatientId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sensors_Patients_PatientId",
                table: "Sensors",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
