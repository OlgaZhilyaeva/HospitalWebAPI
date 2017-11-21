using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PrescriptionsController : Controller
    {
        private HospitalContext db;
        public PrescriptionsController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Prescription> Get()
        {
            return db.Prescriptions;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Prescription Get(int id)
        {
            return db.Prescriptions.Where(x=>x.PrescriptionId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Prescription value)
        {
            db.Prescriptions.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Prescription prescription = db.Prescriptions.Where(x => x.PrescriptionId == id).FirstOrDefault();
            db.Prescriptions.Remove(prescription);
            db.SaveChanges();
        }
    }
}
