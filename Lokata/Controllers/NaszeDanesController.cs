using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DyskusjaSR.Models;

namespace DyskusjaSR.Controllers
{
    public class NaszeDanesController : Controller
    {
        private NaszeDaneContext db = new NaszeDaneContext();

        // GET: NaszeDanes
        public ActionResult Index()
        {
            return View(db.NaszeDane.ToList());
        }

        // GET: NaszeDanes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NaszeDane naszeDane = db.NaszeDane.Find(id);
            if (naszeDane == null)
            {
                return HttpNotFound();
            }
            return View(naszeDane);
        }

        // GET: NaszeDanes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NaszeDanes/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NazwaBanku,KapitałPoczątkowy,DataRozpoczęcia,Oprocentowanie,Zysk")] NaszeDane naszeDane)
        {
            if (ModelState.IsValid)
            {
                db.NaszeDane.Add(naszeDane);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(naszeDane);
        }

        // GET: NaszeDanes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NaszeDane naszeDane = db.NaszeDane.Find(id);
            if (naszeDane == null)
            {
                return HttpNotFound();
            }
            return View(naszeDane);
        }

        // POST: NaszeDanes/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NazwaBanku,KapitałPoczątkowy,DataRozpoczęcia,Oprocentowanie,Zysk")] NaszeDane naszeDane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(naszeDane).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(naszeDane);
        }

        // GET: NaszeDanes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NaszeDane naszeDane = db.NaszeDane.Find(id);
            if (naszeDane == null)
            {
                return HttpNotFound();
            }
            return View(naszeDane);
        }

        // POST: NaszeDanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NaszeDane naszeDane = db.NaszeDane.Find(id);
            db.NaszeDane.Remove(naszeDane);
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
