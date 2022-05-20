using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DomingoRoofWorks;

namespace DomingoRoofWorks.Controllers
{
    public class JOB_DETAILSController : Controller
    {
        private DomingoRoofWorksEntities db = new DomingoRoofWorksEntities();

        // GET: JOB_DETAILS
        public ActionResult Index()
        {
            return View(db.JOB_DETAILS.ToList());
        }

        // GET: JOB_DETAILS/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JOB_DETAILS jOB_DETAILS = db.JOB_DETAILS.Find(id);
            if (jOB_DETAILS == null)
            {
                return HttpNotFound();
            }
            return View(jOB_DETAILS);
        }

        // GET: JOB_DETAILS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JOB_DETAILS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JOB_TYPE_ID,JOB_TYPE_NAME,DAILY_RATE")] JOB_DETAILS jOB_DETAILS)
        {
            if (ModelState.IsValid)
            {
                db.JOB_DETAILS.Add(jOB_DETAILS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jOB_DETAILS);
        }

        // GET: JOB_DETAILS/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JOB_DETAILS jOB_DETAILS = db.JOB_DETAILS.Find(id);
            if (jOB_DETAILS == null)
            {
                return HttpNotFound();
            }
            return View(jOB_DETAILS);
        }

        // POST: JOB_DETAILS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JOB_TYPE_ID,JOB_TYPE_NAME,DAILY_RATE")] JOB_DETAILS jOB_DETAILS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jOB_DETAILS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jOB_DETAILS);
        }

        // GET: JOB_DETAILS/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JOB_DETAILS jOB_DETAILS = db.JOB_DETAILS.Find(id);
            if (jOB_DETAILS == null)
            {
                return HttpNotFound();
            }
            return View(jOB_DETAILS);
        }

        // POST: JOB_DETAILS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            JOB_DETAILS jOB_DETAILS = db.JOB_DETAILS.Find(id);
            db.JOB_DETAILS.Remove(jOB_DETAILS);
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
