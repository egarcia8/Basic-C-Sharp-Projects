using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            var result = db.Insurees.ToList();
            return View(result);
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {                    
                    var currentYear = DateTime.Now;
                    var age = currentYear.Year - insuree.DateOfBirth.Year;

                    decimal quote = GetMonthlyTotalByAge(age) + GetMonthlyTotalByCarYear(insuree.CarYear) + GetMonthlyTotalByMakeAndModel(insuree.CarMake, insuree.CarModel) + GetMonthlyTotalBySpeedingTicket(insuree.SpeedingTickets);

                    if (insuree.CoverageType)
                    {
                        quote *= 1.50M;
                    }

                    if (insuree.DUI)
                    {
                        quote *= 1.25M;
                    }
                    decimal roundedQuote = Math.Round(quote, 2);
                    insuree.Quote = roundedQuote;
                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        private int GetMonthlyTotalByAge(int age)
        {
            const int basePrice = 50;
            var monthlyTotalByAge = 0;
            if (age <= 18)
            {
                monthlyTotalByAge = basePrice + 100;
            }
            else if (age >= 19 && age <= 25)
            {
                monthlyTotalByAge = basePrice + 50;
            }
            else if (age >= 26)
            {
                monthlyTotalByAge = basePrice + 25;
            }
            return monthlyTotalByAge;
        }

        private int GetMonthlyTotalByCarYear(int carYear)
        {
            var monthlyTotalByCarYear = 0;
            if (carYear < 2000 || carYear > 2015)
            {
                monthlyTotalByCarYear = 25;
            }
            return monthlyTotalByCarYear;
        }

        private int GetMonthlyTotalByMakeAndModel(string carMake, string carModel)
        {
            var montlyTotalByMakeAndModel = 0;
            if (carMake == "Porsche" && carModel != "911 Carrera")
            {
                montlyTotalByMakeAndModel = 25;
            }
            else if (carMake == "Porsche" && carModel == "911 Carrera")
            {
                montlyTotalByMakeAndModel = 50;
            }
            return montlyTotalByMakeAndModel;
        }

        private int GetMonthlyTotalBySpeedingTicket(int speedTickets)
        {
            var monthlyTotalBySpeedingTickets = 0;
            if (speedTickets > 0)
            {
                monthlyTotalBySpeedingTickets = speedTickets * 10;
            }
            return monthlyTotalBySpeedingTickets;
        }

        public ActionResult Admin()
        {
            var result = db.Insurees.ToList();

            var temp = new List<InsureeVm>();

            foreach (var item in result)
            {
                temp.Add(new InsureeVm()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Quote = Math.Round(item.Quote, 2),
                    EmailAddress = item.EmailAddress
                });              
            }

            return View(temp);
        }
    }
}
