using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MedicinesController : Controller
    {
        private HospitalContext db;
        public MedicinesController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Medicine> Get()
        {
            return db.Medicines;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Medicine Get(int id)
        {
            return db.Medicines.Where(x=>x.MedicineId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Medicine value)
        {
            db.Medicines.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Medicine medicine = db.Medicines.Where(x => x.MedicineId == id).FirstOrDefault();
            db.Medicines.Remove(medicine);
            db.SaveChanges();
        }
    }
}
