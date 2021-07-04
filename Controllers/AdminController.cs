using Graduation_project3.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Graduation_project3.Controllers
{
    public class AdminController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        // GET: api/Search
        public IHttpActionResult Search(BloodType B)
        {


            try
            {

                var blood = db.Users.Where(p => p.Blood_Type == B).ToList();
                return Ok(blood);
            }

            catch
            {

                return null;

            }


        }
        [HttpGet]
        public IHttpActionResult GetAllUsers()
        {
            try
            {

                var user = db.Users.ToList();

                return Ok(user);
            }

            catch
            {

                return null;

            }
        }
        [HttpGet]
        public IHttpActionResult GetUserDetal(string UserName)
        {
            try
            {

                var user = db.Users.Where(pp => pp.UserName == UserName).ToArray();
                return Ok(user);
            }

            catch
            {

                return null;

            }
        }
        [HttpPost]
        public IHttpActionResult CheckDont(ChangeDonateBindingModel model)
        {
            ApplicationUser user = db.Users.Find(model.Id);
            if (user.Id == model.Id && model.Donate_thr_us == true)
            {
                user.Donator_Thto_Us = true;
                db.Users.AddOrUpdate(user);

            }
            else
            {
                user.Donator_Thto_Us = false;
                db.Users.AddOrUpdate(user);
            }
            db.SaveChanges();
            return Ok();
        }
        [HttpPost]
        [Route("Age")]
        public IHttpActionResult Age(AgeBindingModel model)
        {
            ApplicationUser user = db.Users.Find(model.Id);
            if (user.Id == model.Id)
            {
                user.Age = model.Age;
            }
            db.SaveChanges();
            return Ok();
        }


        [HttpGet]
        [Route("list of Request")]
        public IHttpActionResult GetRequests()
        {
            try
            {
                var user = db.Users.Where(pp => pp.requests == true).ToList();
                return Ok(user);
            }

            catch
            {

                return null;

            }

        }
        
        
        [HttpPost]
        [Route("Response")]
        public IHttpActionResult Response(ResponseBindingModel model)
        {
            ApplicationUser user = db.Users.Find(model.Id);
            if (user.Id == model.Id)
            {
                user.Response = model.response;
                db.Users.AddOrUpdate(user);

            }
            else
            {
                return null;
            }
            db.SaveChanges();
            return Ok();
        }

    }
}
