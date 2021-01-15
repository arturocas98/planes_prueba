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
    public class PPI_TBL_PLAN_PRUEBASController : Controller
    {
        private planes_pruebaEntities3 db = new planes_pruebaEntities3();

        // GET: PPI_TBL_PLAN_PRUEBAS
        public ActionResult Index()
        {
            var pPI_TBL_PLAN_PRUEBAS = db.PPI_TBL_PLAN_PRUEBAS.Include(p => p.PPI_TBL_LIDER_PDS).Include(p => p.PPI_TBL_LIDER_PDS1);
            return View(pPI_TBL_PLAN_PRUEBAS.ToList());
        }

        // GET: PPI_TBL_PLAN_PRUEBAS/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PPI_TBL_PLAN_PRUEBAS pPI_TBL_PLAN_PRUEBAS = db.PPI_TBL_PLAN_PRUEBAS.Find(id);
            if (pPI_TBL_PLAN_PRUEBAS == null)
            {
                return HttpNotFound();
            }
            return View(pPI_TBL_PLAN_PRUEBAS);
        }

        // GET: PPI_TBL_PLAN_PRUEBAS/Create
        public ActionResult Create()
        {
            ViewBag.LIDER_PDS_PROYECTO = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE");
            ViewBag.LIDER_PDS_RESPONSABLE = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE");
            return View();
        }

        // POST: PPI_TBL_PLAN_PRUEBAS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PRUEBAS,CODIGO_PROYECTO,LIDER_PDS_PROYECTO,LIDER_PDS_RESPONSABLE,FECHA_CREACION,FECHA_EVALUACION,FECHA_MODIFICACION,DESCRIPCION,DATOS_PRUEBA,CONCLUSIONES,MODULO,CREADOR_POR,ESTADO")] PPI_TBL_PLAN_PRUEBAS pPI_TBL_PLAN_PRUEBAS)
        {
            if (ModelState.IsValid)
            {
                db.PPI_TBL_PLAN_PRUEBAS.Add(pPI_TBL_PLAN_PRUEBAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LIDER_PDS_PROYECTO = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE", pPI_TBL_PLAN_PRUEBAS.LIDER_PDS_PROYECTO);
            ViewBag.LIDER_PDS_RESPONSABLE = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE", pPI_TBL_PLAN_PRUEBAS.LIDER_PDS_RESPONSABLE);
            return View(pPI_TBL_PLAN_PRUEBAS);
        }

        // GET: PPI_TBL_PLAN_PRUEBAS/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PPI_TBL_PLAN_PRUEBAS pPI_TBL_PLAN_PRUEBAS = db.PPI_TBL_PLAN_PRUEBAS.Find(id);
            if (pPI_TBL_PLAN_PRUEBAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.LIDER_PDS_PROYECTO = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE", pPI_TBL_PLAN_PRUEBAS.LIDER_PDS_PROYECTO);
            ViewBag.LIDER_PDS_RESPONSABLE = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE", pPI_TBL_PLAN_PRUEBAS.LIDER_PDS_RESPONSABLE);
            return View(pPI_TBL_PLAN_PRUEBAS);
        }

        // POST: PPI_TBL_PLAN_PRUEBAS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PRUEBAS,CODIGO_PROYECTO,LIDER_PDS_PROYECTO,LIDER_PDS_RESPONSABLE,FECHA_CREACION,FECHA_EVALUACION,FECHA_MODIFICACION,DESCRIPCION,DATOS_PRUEBA,CONCLUSIONES,MODULO,CREADOR_POR,ESTADO")] PPI_TBL_PLAN_PRUEBAS pPI_TBL_PLAN_PRUEBAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pPI_TBL_PLAN_PRUEBAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LIDER_PDS_PROYECTO = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE", pPI_TBL_PLAN_PRUEBAS.LIDER_PDS_PROYECTO);
            ViewBag.LIDER_PDS_RESPONSABLE = new SelectList(db.PPI_TBL_LIDER_PDS, "ID_LIDER_PDS", "NOMBRE", pPI_TBL_PLAN_PRUEBAS.LIDER_PDS_RESPONSABLE);
            return View(pPI_TBL_PLAN_PRUEBAS);
        }

        // GET: PPI_TBL_PLAN_PRUEBAS/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PPI_TBL_PLAN_PRUEBAS pPI_TBL_PLAN_PRUEBAS = db.PPI_TBL_PLAN_PRUEBAS.Find(id);
            if (pPI_TBL_PLAN_PRUEBAS == null)
            {
                return HttpNotFound();
            }
            return View(pPI_TBL_PLAN_PRUEBAS);
        }

        // POST: PPI_TBL_PLAN_PRUEBAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PPI_TBL_PLAN_PRUEBAS pPI_TBL_PLAN_PRUEBAS = db.PPI_TBL_PLAN_PRUEBAS.Find(id);
            db.PPI_TBL_PLAN_PRUEBAS.Remove(pPI_TBL_PLAN_PRUEBAS);
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
