using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class DoctorsController : Controller
    {
        private HospitalContext db;
        public DoctorsController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return db.Doctors.Include(x => x.Department);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return db.Doctors.Where(x=>x.DoctorId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Doctor value)
        {
            db.Doctors.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Doctor person = db.Doctors.Where(x => x.DoctorId == id).FirstOrDefault();
            db.Doctors.Remove(person);
            db.SaveChanges();
        }
    }
}
