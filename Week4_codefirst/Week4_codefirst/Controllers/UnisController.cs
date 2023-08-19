using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week4_codefirst.Models;

namespace Week4_codefirst.Controllers
{
    public class UnisController : Controller
    {
        private MvcUniContext db = new MvcUniContext();

        // GET: Unis
        public ActionResult Index()
        {
            return View(db.Unis.ToList());
        }

        // GET: Unis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uni uni = db.Unis.Find(id);
            if (uni == null)
            {
                return HttpNotFound();
            }
            return View(uni);
        }

        // GET: Unis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unis/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性。有关
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UniName,Campus")] Uni uni)
        {
            if (ModelState.IsValid)
            {
                db.Unis.Add(uni);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uni);
        }

        // GET: Unis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uni uni = db.Unis.Find(id);
            if (uni == null)
            {
                return HttpNotFound();
            }
            return View(uni);
        }

        // POST: Unis/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性。有关
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UniName,Campus")] Uni uni)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uni).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uni);
        }

        // GET: Unis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uni uni = db.Unis.Find(id);
            if (uni == null)
            {
                return HttpNotFound();
            }
            return View(uni);
        }

        // POST: Unis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uni uni = db.Unis.Find(id);
            db.Unis.Remove(uni);
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
