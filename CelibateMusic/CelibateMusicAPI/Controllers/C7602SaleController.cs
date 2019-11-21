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
    public class C7602SaleController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C7602Sale
        public IQueryable<C7602Sale> GetC7602Sale()
        {
            return db.C7602Sale;
        }

        // GET: api/C7602Sale/5
        [ResponseType(typeof(C7602Sale))]
        public IHttpActionResult GetC7602Sale(DateTime id)
        {
            C7602Sale c7602Sale = db.C7602Sale.Find(id);
            if (c7602Sale == null)
            {
                return NotFound();
            }

            return Ok(c7602Sale);
        }

        // PUT: api/C7602Sale/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutC7602Sale(DateTime id, C7602Sale c7602Sale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c7602Sale.SaleDate)
            {
                return BadRequest();
            }

            db.Entry(c7602Sale).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C7602SaleExists(id))
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

        // POST: api/C7602Sale
        [ResponseType(typeof(C7602Sale))]
        public IHttpActionResult PostC7602Sale(C7602Sale c7602Sale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C7602Sale.Add(c7602Sale);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (C7602SaleExists(c7602Sale.SaleDate))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c7602Sale.SaleDate }, c7602Sale);
        }

        // DELETE: api/C7602Sale/5
        [ResponseType(typeof(C7602Sale))]
        public IHttpActionResult DeleteC7602Sale(DateTime id)
        {
            C7602Sale c7602Sale = db.C7602Sale.Find(id);
            if (c7602Sale == null)
            {
                return NotFound();
            }

            db.C7602Sale.Remove(c7602Sale);
            db.SaveChanges();

            return Ok(c7602Sale);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C7602SaleExists(DateTime id)
        {
            return db.C7602Sale.Count(e => e.SaleDate == id) > 0;
        }
    }
}