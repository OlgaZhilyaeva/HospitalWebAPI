using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TemperaturesController : Controller
    {
        private HospitalContext db;
        public TemperaturesController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Temperature> Get()
        {
            return db.Temperatures;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Temperature Get(int id)
        {
            return db.Temperatures.Where(x=>x.TemperatureId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Temperature value)
        {
            db.Temperatures.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Temperature temperature = db.Temperatures.Where(x => x.TemperatureId == id).FirstOrDefault();
            db.Temperatures.Remove(temperature);
            db.SaveChanges();
        }
    }
}
