﻿// <auto-generated />
using HospitalWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HospitalWebApi.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20180412154453_UsersUpdate")]
    partial class UsersUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalWebApi.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("HospitalId");

                    b.Property<string>("Name");

                    b.HasKey("DepartmentId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("DigitalSign");

                    b.Property<string>("Name");

                    b.Property<int?>("PrescriptionId");

                    b.Property<string>("Surname");

                    b.Property<int?>("UserHospitalUserId");

                    b.HasKey("DoctorId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PrescriptionId");

                    b.HasIndex("UserHospitalUserId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Documents");

                    b.Property<string>("Name");

                    b.HasKey("HospitalId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("HospitalWebApi.Models.HospitalUser", b =>
                {
                    b.Property<int>("HospitalUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("HospitalUserId");

                    b.ToTable("HospitalUsers");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.Property<string>("Value");

                    b.HasKey("MedicineId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Nurse", b =>
                {
                    b.Property<int>("NurseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("DigitalSign");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<int?>("UserHospitalUserId");

                    b.HasKey("NurseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserHospitalUserId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Documents");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<int?>("UserHospitalUserId");

                    b.Property<int?>("WardId");

                    b.HasKey("PatientId");

                    b.HasIndex("UserHospitalUserId");

                    b.HasIndex("WardId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Duration");

                    b.Property<int?>("MedicineId");

                    b.Property<string>("MedicineQuantity");

                    b.Property<string>("Name");

                    b.Property<int?>("PatientId");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Sensor", b =>
                {
                    b.Property<int>("SensorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PatientId");

                    b.Property<int?>("TemperatureId");

                    b.HasKey("SensorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("TemperatureId");

                    b.ToTable("Sensors");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Temperature", b =>
                {
                    b.Property<int>("TemperatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<decimal>("Value");

                    b.HasKey("TemperatureId");

                    b.ToTable("Temperatures");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Ward", b =>
                {
                    b.Property<int>("WardId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Name");

                    b.HasKey("WardId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Wards");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Department", b =>
                {
                    b.HasOne("HospitalWebApi.Models.Hospital")
                        .WithMany("Departments")
                        .HasForeignKey("HospitalId");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Doctor", b =>
                {
                    b.HasOne("HospitalWebApi.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("HospitalWebApi.Models.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId");

                    b.HasOne("HospitalWebApi.Models.HospitalUser", "User")
                        .WithMany()
                        .HasForeignKey("UserHospitalUserId");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Nurse", b =>
                {
                    b.HasOne("HospitalWebApi.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("HospitalWebApi.Models.HospitalUser", "User")
                        .WithMany()
                        .HasForeignKey("UserHospitalUserId");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Patient", b =>
                {
                    b.HasOne("HospitalWebApi.Models.HospitalUser", "User")
                        .WithMany()
                        .HasForeignKey("UserHospitalUserId");

                    b.HasOne("HospitalWebApi.Models.Ward", "Ward")
                        .WithMany()
                        .HasForeignKey("WardId");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Prescription", b =>
                {
                    b.HasOne("HospitalWebApi.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId");

                    b.HasOne("HospitalWebApi.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Sensor", b =>
                {
                    b.HasOne("HospitalWebApi.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("HospitalWebApi.Models.Temperature", "Temperature")
                        .WithMany()
                        .HasForeignKey("TemperatureId");
                });

            modelBuilder.Entity("HospitalWebApi.Models.Ward", b =>
                {
                    b.HasOne("HospitalWebApi.Models.Department", "Department")
                        .WithMany("Wards")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
