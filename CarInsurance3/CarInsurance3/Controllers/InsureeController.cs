using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance3.Models;

namespace CarInsurance3.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree table = db.Insurees.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree table)
        {

            if (ModelState.IsValid)
            {

                decimal quoteAmount = 50;


                int theirAge = (DateTime.Now.Year - table.DateOfBirth.Year);
                if (theirAge <= 18)
                {
                    quoteAmount += 100;
                }
                else if (theirAge >= 19 && theirAge <= 25)
                {
                    quoteAmount += 50;
                }
                else
                {
                    quoteAmount += 25;
                }
                if (table.CarYear < 2000)
                {
                    quoteAmount += 25;
                }
                else if (table.CarYear > 2015)
                {
                    quoteAmount += 25;
                }
                if (table.CarMake == "Porsche")
                {
                    quoteAmount += 25;
                    if (table.CarModel == "911 Carrera")
                    {
                        quoteAmount += 25;
                    }
                }
                for (int i = 0; i < table.SpeedingTickets; i++)
                {
                    quoteAmount += 10;
                }
                if (table.DUI)
                {
                    quoteAmount *= 1.25m;
                }
                if (table.CoverageType)
                {
                    quoteAmount *= 1.50m;
                }
                table.Quote = quoteAmount;

                db.Insurees.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree table = db.Insurees.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree table = db.Insurees.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree table = db.Insurees.Find(id);
            db.Insurees.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Admin()
        {

            return View(db.Insurees.ToList());
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
