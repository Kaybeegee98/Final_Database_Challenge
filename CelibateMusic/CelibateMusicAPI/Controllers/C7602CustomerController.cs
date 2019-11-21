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
    public class C7602CustomerController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C7602Customer
        public IQueryable<C7602Customer> GetC7602Customer()
        {
            return db.C7602Customer;
        }

        // GET: api/C7602Customer/5
        [ResponseType(typeof(C7602Customer))]
        public IHttpActionResult GetC7602Customer(int id)
        {
            C7602Customer c7602Customer = db.C7602Customer.Find(id);
            if (c7602Customer == null)
            {
                return NotFound();
            }

            return Ok(c7602Customer);
        }

        // PUT: api/C7602Customer/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutC7602Customer(int id, C7602Customer c7602Customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c7602Customer.CustomerNumber)
            {
                return BadRequest();
            }

            db.Entry(c7602Customer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C7602CustomerExists(id))
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

        // POST: api/C7602Customer
        [ResponseType(typeof(C7602Customer))]
        public IHttpActionResult PostC7602Customer(C7602Customer c7602Customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C7602Customer.Add(c7602Customer);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (C7602CustomerExists(c7602Customer.CustomerNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c7602Customer.CustomerNumber }, c7602Customer);
        }

        // DELETE: api/C7602Customer/5
        [ResponseType(typeof(C7602Customer))]
        public IHttpActionResult DeleteC7602Customer(int id)
        {
            C7602Customer c7602Customer = db.C7602Customer.Find(id);
            if (c7602Customer == null)
            {
                return NotFound();
            }

            db.C7602Customer.Remove(c7602Customer);
            db.SaveChanges();

            return Ok(c7602Customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C7602CustomerExists(int id)
        {
            return db.C7602Customer.Count(e => e.CustomerNumber == id) > 0;
        }
    }
}