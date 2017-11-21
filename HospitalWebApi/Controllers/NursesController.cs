using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class NursesController : Controller
    {
        private HospitalContext db;
        public NursesController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return db.Nurses.Include(x => x.Department);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Nurse Get(int id)
        {
            return db.Nurses.Where(x=>x.NurseId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Nurse value)
        {
            db.Nurses.Add(value);
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Nurse nurse = db.Nurses.Where(x => x.NurseId == id).FirstOrDefault();
            db.Nurses.Remove(nurse);
            db.SaveChanges();
        }
    }
}
