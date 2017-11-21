using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class WardsController : Controller
    {
        private HospitalContext db;
        public WardsController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Ward> Get()
        {
            return db.Wards;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Ward Get(int id)
        {
            return db.Wards.Where(x=>x.WardId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Ward value)
        {
            db.Wards.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Ward ward = db.Wards.Where(x => x.WardId == id).FirstOrDefault();
            db.Wards.Remove(ward);
            db.SaveChanges();
        }
    }
}
