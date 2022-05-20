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
    public class JOBsController : Controller
    {
        private DomingoRoofWorksEntities db = new DomingoRoofWorksEntities();

        // GET: JOBs
        public ActionResult Index()
        {
            var jOBs = db.JOBs.Include(j => j.CUSTOMER).Include(j => j.JOB_DETAILS);
            return View(jOBs.ToList());
        }

        // GET: JOBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JOB jOB = db.JOBs.Find(id);
            if (jOB == null)
            {
                return HttpNotFound();
            }
            return View(jOB);
        }

        // GET: JOBs/Create
        public ActionResult Create()
        {
            ViewBag.CUSTOMER_ID = new SelectList(db.CUSTOMERs, "CUSTOMER_ID", "CUSTOMER_FISRT_NAME");
            ViewBag.JOB_TYPE_ID = new SelectList(db.JOB_DETAILS, "JOB_TYPE_ID", "JOB_TYPE_NAME");
            return View();
        }

        // POST: JOBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JOB_CARD_NO,CUSTOMER_ID,JOB_TYPE_ID,START_DATE,END_DATE,NUM_OF_DAYS")] JOB jOB)
        {
            if (ModelState.IsValid)
            {
                db.JOBs.Add(jOB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CUSTOMER_ID = new SelectList(db.CUSTOMERs, "CUSTOMER_ID", "CUSTOMER_FISRT_NAME", jOB.CUSTOMER_ID);
            ViewBag.JOB_TYPE_ID = new SelectList(db.JOB_DETAILS, "JOB_TYPE_ID", "JOB_TYPE_NAME", jOB.JOB_TYPE_ID);
            return View(jOB);
        }

        // GET: JOBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JOB jOB = db.JOBs.Find(id);
            if (jOB == null)
            {
                return HttpNotFound();
            }
            ViewBag.CUSTOMER_ID = new SelectList(db.CUSTOMERs, "CUSTOMER_ID", "CUSTOMER_FISRT_NAME", jOB.CUSTOMER_ID);
            ViewBag.JOB_TYPE_ID = new SelectList(db.JOB_DETAILS, "JOB_TYPE_ID", "JOB_TYPE_NAME", jOB.JOB_TYPE_ID);
            return View(jOB);
        }

        // POST: JOBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JOB_CARD_NO,CUSTOMER_ID,JOB_TYPE_ID,START_DATE,END_DATE,NUM_OF_DAYS")] JOB jOB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jOB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CUSTOMER_ID = new SelectList(db.CUSTOMERs, "CUSTOMER_ID", "CUSTOMER_FISRT_NAME", jOB.CUSTOMER_ID);
            ViewBag.JOB_TYPE_ID = new SelectList(db.JOB_DETAILS, "JOB_TYPE_ID", "JOB_TYPE_NAME", jOB.JOB_TYPE_ID);
            return View(jOB);
        }

        // GET: JOBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JOB jOB = db.JOBs.Find(id);
            if (jOB == null)
            {
                return HttpNotFound();
            }
            return View(jOB);
        }

        // POST: JOBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JOB jOB = db.JOBs.Find(id);
            db.JOBs.Remove(jOB);
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
