using System;
using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TemperaturesController : Controller
    {
        private HospitalContext db;
        private UsersController _usersController;
        public TemperaturesController(HospitalContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Temperature> Get()
        {
            var sessVar = HttpContext.Session.GetString(UsersController.SessionName);

            if (sessVar == null)
            {
                Response.StatusCode = 401;
                return null;
            }

            var sessionVariable = Int32.Parse(sessVar);

            Patient patient = db.Patients.Include(x => x.User).FirstOrDefault(x => x.User.HospitalUserId == sessionVariable);
            var temp = db.Temperatures.Where(x => x.Patient.PatientId == patient.PatientId);

            return temp;
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
            var sessionVariable = Int32.Parse(HttpContext.Session.GetString(UsersController.SessionName));
            Patient patient = db.Patients.Include(x => x.User).FirstOrDefault(x => x.User.HospitalUserId == sessionVariable);

            if (patient == null)
                throw new NullReferenceException();

            value.Patient = patient;
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
