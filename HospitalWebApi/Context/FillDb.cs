using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Models;

namespace HospitalWebApi.Context
{
    public class FillDb
    {
        private HospitalContext _context;
        public FillDb(HospitalContext db)
        {
            _context = db;
        }

        public void Wards()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }

        public void Departments()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }

        public void Hospitals()
        {
            _context.Hospitals.Add(new Hospital() { HospitalId = 1, Name = "House of health", Documents = "Registration №12344765", Adress = "Kharkiv, 1 Chkalova street" });
            _context.SaveChanges();
        }

        public List<Patient> Patients()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
            return _context.Patients.ToList();
        }

        public void Doctors()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }

        public void Nurses()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }

        public void Medicines()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }

        public void Prescriptions()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }

        public void Sensors()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }

        public void Temperature()
        {
            _context.Patients.Add(new Patient() { PatientId = 1, Documents = "Passport: ET307286", Name = "Valentin", Surname = "Petrov" });
            _context.SaveChanges();
        }
    }
}
