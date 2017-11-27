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
using SOAP_SERVICE.Models;

namespace SOAP_SERVICE.Persistence
{
    public class LecturasModelsController : ApiController
    {
        private SOAP_SERVICEContext db = new SOAP_SERVICEContext();

        // GET: api/LecturasModels
        public IQueryable<LecturasModel> GetLecturasModels()
        {
            return db.LecturasModels;
        }

        // GET: api/LecturasModels/5
        [ResponseType(typeof(LecturasModel))]
        public IHttpActionResult GetLecturasModel(int id)
        {
            LecturasModel lecturasModel = db.LecturasModels.Find(id);
            if (lecturasModel == null)
            {
                return NotFound();
            }

            return Ok(lecturasModel);
        }

        // PUT: api/LecturasModels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLecturasModel(int id, LecturasModel lecturasModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lecturasModel.Id)
            {
                return BadRequest();
            }

            db.Entry(lecturasModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LecturasModelExists(id))
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

        // POST: api/LecturasModels
        [ResponseType(typeof(LecturasModel))]
        public IHttpActionResult PostLecturasModel(LecturasModel lecturasModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LecturasModels.Add(lecturasModel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lecturasModel.Id }, lecturasModel);
        }

        // DELETE: api/LecturasModels/5
        [ResponseType(typeof(LecturasModel))]
        public IHttpActionResult DeleteLecturasModel(int id)
        {
            LecturasModel lecturasModel = db.LecturasModels.Find(id);
            if (lecturasModel == null)
            {
                return NotFound();
            }

            db.LecturasModels.Remove(lecturasModel);
            db.SaveChanges();

            return Ok(lecturasModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LecturasModelExists(int id)
        {
            return db.LecturasModels.Count(e => e.Id == id) > 0;
        }
    }
}