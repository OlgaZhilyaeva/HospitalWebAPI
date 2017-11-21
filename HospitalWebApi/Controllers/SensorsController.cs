using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class SensorsController : Controller
    {
        private HospitalContext db;
        public SensorsController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Sensor> Get()
        {
            return db.Sensors;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Sensor Get(int id)
        {
            return db.Sensors.Where(x=>x.SensorId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Sensor value)
        {
            db.Sensors.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Sensor sensor = db.Sensors.Where(x => x.SensorId == id).FirstOrDefault();
            db.Sensors.Remove(sensor);
            db.SaveChanges();
        }
    }
}
