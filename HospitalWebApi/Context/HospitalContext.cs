using HospitalWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Context
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<HospitalUser> HospitalUsers { get; set; }
    }
}
