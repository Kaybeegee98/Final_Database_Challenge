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
    public class C7602RecordController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C7602Record
        public IQueryable<C7602Record> GetC7602Record()
        {
            return db.C7602Record;
        }

        // GET: api/C7602Record/5
        [ResponseType(typeof(C7602Record))]
        public IHttpActionResult GetC7602Record(string id)
        {
            C7602Record c7602Record = db.C7602Record.Find(id);
            if (c7602Record == null)
            {
                return NotFound();
            }

            return Ok(c7602Record);
        }

        // PUT: api/C7602Record/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutC7602Record(string id, C7602Record c7602Record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c7602Record.RecordID)
            {
                return BadRequest();
            }

            db.Entry(c7602Record).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C7602RecordExists(id))
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

        // POST: api/C7602Record
        [ResponseType(typeof(C7602Record))]
        public IHttpActionResult PostC7602Record(C7602Record c7602Record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C7602Record.Add(c7602Record);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (C7602RecordExists(c7602Record.RecordID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c7602Record.RecordID }, c7602Record);
        }

        // DELETE: api/C7602Record/5
        [ResponseType(typeof(C7602Record))]
        public IHttpActionResult DeleteC7602Record(string id)
        {
            C7602Record c7602Record = db.C7602Record.Find(id);
            if (c7602Record == null)
            {
                return NotFound();
            }

            db.C7602Record.Remove(c7602Record);
            db.SaveChanges();

            return Ok(c7602Record);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C7602RecordExists(string id)
        {
            return db.C7602Record.Count(e => e.RecordID == id) > 0;
        }
    }
}