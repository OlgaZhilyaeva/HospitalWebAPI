using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HospitalWebApi.Migrations
{
    public partial class UsersUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "UserHospitalUserId",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserHospitalUserId",
                table: "Nurses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserHospitalUserId",
                table: "Doctors",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HospitalUsers",
                columns: table => new
                {
                    HospitalUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalUsers", x => x.HospitalUserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserHospitalUserId",
                table: "Patients",
                column: "UserHospitalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_UserHospitalUserId",
                table: "Nurses",
                column: "UserHospitalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserHospitalUserId",
                table: "Doctors",
                column: "UserHospitalUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_HospitalUsers_UserHospitalUserId",
                table: "Doctors",
                column: "UserHospitalUserId",
                principalTable: "HospitalUsers",
                principalColumn: "HospitalUserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_HospitalUsers_UserHospitalUserId",
                table: "Nurses",
                column: "UserHospitalUserId",
                principalTable: "HospitalUsers",
                principalColumn: "HospitalUserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_HospitalUsers_UserHospitalUserId",
                table: "Patients",
                column: "UserHospitalUserId",
                principalTable: "HospitalUsers",
                principalColumn: "HospitalUserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_HospitalUsers_UserHospitalUserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_HospitalUsers_UserHospitalUserId",
                table: "Nurses");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_HospitalUsers_UserHospitalUserId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "HospitalUsers");

            migrationBuilder.DropIndex(
                name: "IX_Patients_UserHospitalUserId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_UserHospitalUserId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserHospitalUserId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UserHospitalUserId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UserHospitalUserId",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "UserHospitalUserId",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Nurses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Doctors",
                nullable: true);
        }
    }
}
