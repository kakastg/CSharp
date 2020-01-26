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
        private GryContext db = new GryContext();

        // GET: Gries
        public ActionResult Index()
        {
            return View(db.gry.ToList());
        }

        // GET: Gries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gry gry = db.gry.Find(id);
            if (gry == null)
            {
                return HttpNotFound();
            }
            return View(gry);
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
        public ActionResult Create([Bind(Include = "GryId,Nazwa,Rok,Wydawca")] Gry gry)
        {
            if (ModelState.IsValid)
            {
                db.gry.Add(gry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gry);
        }

        // GET: Gries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gry gry = db.gry.Find(id);
            if (gry == null)
            {
                return HttpNotFound();
            }
            return View(gry);
        }

        // POST: Gries/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GryId,Nazwa,Rok,Wydawca")] Gry gry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gry);
        }

        // GET: Gries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gry gry = db.gry.Find(id);
            if (gry == null)
            {
                return HttpNotFound();
            }
            return View(gry);
        }

        // POST: Gries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gry gry = db.gry.Find(id);
            db.gry.Remove(gry);
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
        public ActionResult Czat()
        {
            return View();
        }
    }
}
