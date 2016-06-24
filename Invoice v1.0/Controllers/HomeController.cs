﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Invoice_v1._0.Models;

namespace Invoice_v1._0.Controllers
{
    public class HomeController : Controller
    {
        private DaneDoFakturyContext db = new DaneDoFakturyContext();

        // GET: Home
        public ActionResult Index(int id=1)
        {
            DaneDoFakturyContext daneContext = new DaneDoFakturyContext();
            DaneDoFaktury dane = daneContext.DaneDoFaktury.Single(x => x.ID == id);

            return View(dane);
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaneDoFaktury daneDoFaktury = db.DaneDoFaktury.Find(id);
            if (daneDoFaktury == null)
            {
                return HttpNotFound();
            }
            return View(daneDoFaktury);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Surname,Street,NumberOfAddress,Gender,City,Product,Amounts,PriceForOne,Date")] DaneDoFaktury daneDoFaktury)
        {
            if (ModelState.IsValid)
            {
                db.DaneDoFaktury.Add(daneDoFaktury);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = daneDoFaktury.ID });
            }

            return View(daneDoFaktury);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaneDoFaktury daneDoFaktury = db.DaneDoFaktury.Find(id);
            if (daneDoFaktury == null)
            {
                return HttpNotFound();
            }
            return View(daneDoFaktury);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Surname,Gender,City,Product,Amounts,Date")] DaneDoFaktury daneDoFaktury)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daneDoFaktury).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(daneDoFaktury);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaneDoFaktury daneDoFaktury = db.DaneDoFaktury.Find(id);
            if (daneDoFaktury == null)
            {
                return HttpNotFound();
            }
            return View(daneDoFaktury);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DaneDoFaktury daneDoFaktury = db.DaneDoFaktury.Find(id);
            db.DaneDoFaktury.Remove(daneDoFaktury);
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
