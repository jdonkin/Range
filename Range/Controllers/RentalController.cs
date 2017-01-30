using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Range.Models;

namespace Range.Controllers
{
    public class RentalController : Controller
    {
        private RangeContext db = new RangeContext();

        // GET: Rental
        public ActionResult Index()
        {
            return View();
        }

        //// GET: Rental/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Guns guns = db.Guns.Find(id);
        //    if (guns == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(guns);
        //}

        //// GET: Rental/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Rental/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,ModelName,MagazineCapacity,Caliber,ImageLocation")] Guns guns)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Guns.Add(guns);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(guns);
        //}

        //// GET: Rental/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Guns guns = db.Guns.Find(id);
        //    if (guns == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(guns);
        //}

        //// POST: Rental/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,ModelName,MagazineCapacity,Caliber,ImageLocation")] Guns guns)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(guns).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(guns);
        //}

        //// GET: Rental/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Guns guns = db.Guns.Find(id);
        //    if (guns == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(guns);
        //}

        //// POST: Rental/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Guns guns = db.Guns.Find(id);
        //    db.Guns.Remove(guns);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
