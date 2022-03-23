using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameShop.Data;
using GameShop.Models;

namespace GameShop.Controllers
{
    public class ConsolesController : Controller
    {
        private ConsoleContext db = new ConsoleContext();

        // GET: Consoles
        public ActionResult Index()
        {
            return View(db.Consoles.ToList());
        }

        // GET: Consoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Console console = db.Consoles.Find(id);
            if (console == null)
            {
                return HttpNotFound();
            }
            return View(console);
        }

        // GET: Consoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConsoleId,ConsoleName")] Models.Console console)
        {
            if (ModelState.IsValid)
            {
                db.Consoles.Add(console);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(console);
        }

        // GET: Consoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Console console = db.Consoles.Find(id);
            if (console == null)
            {
                return HttpNotFound();
            }
            return View(console);
        }

        // POST: Consoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConsoleId,ConsoleName")] Models.Console console)
        {
            if (ModelState.IsValid)
            {
                db.Entry(console).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(console);
        }

        // GET: Consoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Console console = db.Consoles.Find(id);
            if (console == null)
            {
                return HttpNotFound();
            }
            return View(console);
        }

        // POST: Consoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Models.Console console = db.Consoles.Find(id);
            db.Consoles.Remove(console);
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
