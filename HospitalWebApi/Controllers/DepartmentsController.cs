using System.Collections.Generic;
using System.Linq;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class DepartmentsController : Controller
    {
        private HospitalContext db;
        public DepartmentsController(HospitalContext context)
        {
            db = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return db.Departments;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            return db.Departments.Where(x=>x.DepartmentId == id).FirstOrDefault();
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]Department value)
        {
            db.Departments.Add(value);
            db.SaveChanges();
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Department department = db.Departments.Where(x => x.DepartmentId == id).FirstOrDefault();
            db.Departments.Remove(department);
            db.SaveChanges();
        }
    }
}
