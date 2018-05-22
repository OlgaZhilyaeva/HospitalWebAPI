using System;
using HospitalWebApi.Context;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private HospitalContext db;
        public const string SessionName = "UserId";

        public UsersController(HospitalContext context)
        {
            db = context;
        }

        [HttpGet]
        public IEnumerable<HospitalUser> Get()
        {
            return db.HospitalUsers;
        }

        [HttpGet("{id}")]
        public HospitalUser Get(int id)
        {
            return db.HospitalUsers.Where(x => x.HospitalUserId == id).FirstOrDefault();
        }

        [HttpPost]
        public string Post([FromBody]HospitalUser value)
        {
            try
            {
                var user = db.HospitalUsers.FirstOrDefault(x => x.Login == value.Login);
                if (user != null)
                {
                    if (user.Password == value.Password)
                    {
                        string userId = user.HospitalUserId.ToString();
                        HttpContext.Session.SetString(SessionName, userId);
                        return "true";
                    }
                    Response.StatusCode = 403;
                    return "false";
                }
                else
                {
                    Response.StatusCode = 403;
                    return "false";
                }
            }
            catch (Exception e)
            {
                Response.StatusCode = 500;
                return $"{e.Message}\n\n{e.Source}\n\n{e.StackTrace}";
            }

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            HospitalUser user = db.HospitalUsers.Where(x => x.HospitalUserId == id).FirstOrDefault();
            db.HospitalUsers.Remove(user);
            db.SaveChanges();
        }
    }
}
