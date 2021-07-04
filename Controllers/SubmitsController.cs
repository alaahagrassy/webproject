using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Graduation_project3.Models;

namespace Graduation_project3.Controllers
{
    public class SubmitsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Submits
        public IQueryable<Submit> GetSubmits()
        {
            return db.Submits;
        }

        // GET: api/Submits/5
        [ResponseType(typeof(Submit))]
        public IHttpActionResult GetSubmit(int id)
        {
            Submit submit = db.Submits.Find(id);
            if (submit == null)
            {
                return NotFound();
            }

            return Ok(submit);
        }

        // PUT: api/Submits/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSubmit(int id, Submit submit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != submit.Id)
            {
                return BadRequest();
            }

            db.Entry(submit).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubmitExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Submits
        [ResponseType(typeof(Submit))]
        public IHttpActionResult PostSubmit(Submit submit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Submits.Add(submit);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = submit.Id }, submit);
        }

        // DELETE: api/Submits/5
        [ResponseType(typeof(Submit))]
        public IHttpActionResult DeleteSubmit(int id)
        {
            Submit submit = db.Submits.Find(id);
            if (submit == null)
            {
                return NotFound();
            }

            db.Submits.Remove(submit);
            db.SaveChanges();

            return Ok(submit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SubmitExists(int id)
        {
            return db.Submits.Count(e => e.Id == id) > 0;
        }
    }
}