using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class HospitalsController : Controller
    {
        private HospitalContext db;
        public HospitalsController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Hospital> Get()
        {
            return db.Hospitals;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Hospital Get(int id)
        {
            return db.Hospitals.Where(x=>x.HospitalId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Hospital value)
        {
            db.Hospitals.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Hospital hospital = db.Hospitals.Where(x => x.HospitalId == id).FirstOrDefault();
            db.Hospitals.Remove(hospital);
            db.SaveChanges();
        }
    }
}
