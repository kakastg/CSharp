using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectWeb.Models;

namespace ProjectWeb.Controllers
{
    public class GriesController : Controller
    {
        private DaneGierContext db = new DaneGierContext();

        // GET: Gries
        public ActionResult Index()
        {
            return View(db.DaneGier.ToList());
        }

        // GET: Gries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaneGier daneGier = db.DaneGier.Find(id);
            if (daneGier == null)
            {
                return HttpNotFound();
            }
            return View(daneGier);
        }

        // GET: Gries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gries/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nazwa,RokWydania,Wydawca")] DaneGier daneGier)
        {
            if (ModelState.IsValid)
            {
                db.DaneGier.Add(daneGier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(daneGier);
        }

        // GET: Gries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaneGier daneGier = db.DaneGier.Find(id);
            if (daneGier == null)
            {
                return HttpNotFound();
            }
            return View(daneGier);
        }

        // POST: Gries/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nazwa,RokWydania,Wydawca")] DaneGier daneGier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daneGier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(daneGier);
        }

        // GET: Gries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaneGier daneGier = db.DaneGier.Find(id);
            if (daneGier == null)
            {
                return HttpNotFound();
            }
            return View(daneGier);
        }

        // POST: Gries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DaneGier daneGier = db.DaneGier.Find(id);
            db.DaneGier.Remove(daneGier);
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
