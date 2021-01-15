using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using planes_prueba;

namespace planes_prueba.Controllers
{
    public class PPI_TBL_LIDER_PDSController : Controller
    {
        private planes_pruebaEntities3 db = new planes_pruebaEntities3();

        // GET: PPI_TBL_LIDER_PDS
        public ActionResult Index()
        {
            return View(db.PPI_TBL_LIDER_PDS.ToList());
        }

        // GET: PPI_TBL_LIDER_PDS/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PPI_TBL_LIDER_PDS pPI_TBL_LIDER_PDS = db.PPI_TBL_LIDER_PDS.Find(id);
            if (pPI_TBL_LIDER_PDS == null)
            {
                return HttpNotFound();
            }
            return View(pPI_TBL_LIDER_PDS);
        }

        // GET: PPI_TBL_LIDER_PDS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PPI_TBL_LIDER_PDS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_LIDER_PDS,NOMBRE,ESTADO")] PPI_TBL_LIDER_PDS pPI_TBL_LIDER_PDS)
        {
            if (ModelState.IsValid)
            {
                db.PPI_TBL_LIDER_PDS.Add(pPI_TBL_LIDER_PDS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pPI_TBL_LIDER_PDS);
        }

        // GET: PPI_TBL_LIDER_PDS/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PPI_TBL_LIDER_PDS pPI_TBL_LIDER_PDS = db.PPI_TBL_LIDER_PDS.Find(id);
            if (pPI_TBL_LIDER_PDS == null)
            {
                return HttpNotFound();
            }
            return View(pPI_TBL_LIDER_PDS);
        }

        // POST: PPI_TBL_LIDER_PDS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_LIDER_PDS,NOMBRE,ESTADO")] PPI_TBL_LIDER_PDS pPI_TBL_LIDER_PDS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pPI_TBL_LIDER_PDS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pPI_TBL_LIDER_PDS);
        }

        // GET: PPI_TBL_LIDER_PDS/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PPI_TBL_LIDER_PDS pPI_TBL_LIDER_PDS = db.PPI_TBL_LIDER_PDS.Find(id);
            if (pPI_TBL_LIDER_PDS == null)
            {
                return HttpNotFound();
            }
            return View(pPI_TBL_LIDER_PDS);
        }

        // POST: PPI_TBL_LIDER_PDS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PPI_TBL_LIDER_PDS pPI_TBL_LIDER_PDS = db.PPI_TBL_LIDER_PDS.Find(id);
            db.PPI_TBL_LIDER_PDS.Remove(pPI_TBL_LIDER_PDS);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
