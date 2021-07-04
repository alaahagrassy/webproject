using Graduation_project3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Graduation_project3.Controllers
{
    public class DonatorsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        [HttpGet]
        public IHttpActionResult GetDonators()
        {
            try
            {
                var user = db.Users.Where(p => p.Donator_Thto_Us == true).ToList();
                return Ok(user);
            }

            catch
            {

                return null;

            }
        }
        [HttpGet]
        // GET: api/Search
        public IHttpActionResult Search(BloodType B)
        {


            try
            {

                var blood = db.Users.Where(p => p.Blood_Type == B && p.Donator_Thto_Us == true).ToList();
                return Ok(blood);
            }

            catch
            {

                return null;

            }


        }
        [Route("userRequesData")]
        [HttpPost]

        public IHttpActionResult Result(requestBindingModel model)
        {
            ApplicationUser user = db.Users.Find(model.Id);
            var request = db.Users.Where(p => p.Id == model.Id).Select(p => p.UserName + p.Blood_Type + p.PhoneNumber);



            return Ok(request);

        }
        [Route("Request")]
        public IHttpActionResult CheckRequest(ChangeRequestBindingModel model)
        {
            ApplicationUser user = db.Users.Find(model.Id);
            if (user.Id == model.Id && model.requests == true)
            {
                user.requests = true;
                db.Users.AddOrUpdate(user);

            }
            else
            {
                user.requests = false;
                db.Users.AddOrUpdate(user);
            }
            db.SaveChanges();
            return Ok();
        }
    }
}
