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
using CelibateMusicAPI.Models;

namespace CelibateMusicAPI.Controllers
{
    public class C7602InterestController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C7602Interest
        public IQueryable<C7602Interest> GetC7602Interest()
        {
            return db.C7602Interest;
        }

        // GET: api/C7602Interest/5
        [ResponseType(typeof(C7602Interest))]
        public IHttpActionResult GetC7602Interest(string id)
        {
            C7602Interest c7602Interest = db.C7602Interest.Find(id);
            if (c7602Interest == null)
            {
                return NotFound();
            }

            return Ok(c7602Interest);
        }

        // PUT: api/C7602Interest/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutC7602Interest(string id, C7602Interest c7602Interest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c7602Interest.InterestCode)
            {
                return BadRequest();
            }

            db.Entry(c7602Interest).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C7602InterestExists(id))
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

        // POST: api/C7602Interest
        [ResponseType(typeof(C7602Interest))]
        public IHttpActionResult PostC7602Interest(C7602Interest c7602Interest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            c7602Interest = new C7602Interest("CH", "Chill");

            db.C7602Interest.Add(c7602Interest);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (C7602InterestExists(c7602Interest.InterestCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c7602Interest.InterestCode }, c7602Interest);
        }

        // DELETE: api/C7602Interest/5
        [ResponseType(typeof(C7602Interest))]
        public IHttpActionResult DeleteC7602Interest(string id)
        {
            C7602Interest c7602Interest = db.C7602Interest.Find(id);
            if (c7602Interest == null)
            {
                return NotFound();
            }

            db.C7602Interest.Remove(c7602Interest);
            db.SaveChanges();

            return Ok(c7602Interest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C7602InterestExists(string id)
        {
            return db.C7602Interest.Count(e => e.InterestCode == id) > 0;
        }
    }
}