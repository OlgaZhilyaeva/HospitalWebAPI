using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PatientsController : Controller
    {
        private HospitalContext db;
        public PatientsController (HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return db.Patients.Include(x => x.Ward);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            return db.Patients.Where(x=>x.PatientId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Patient value)
        {
            db.Patients.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Patient person = db.Patients.Where(x => x.PatientId == id).FirstOrDefault();
            db.Patients.Remove(person);
            db.SaveChanges();
        }
    }
}
