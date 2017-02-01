using Range.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Range.Controllers
{
  public class LaneRentalController : Controller
  {
    private RangeContext db = new RangeContext();

    // GET: LaneRental
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Error()
    {
      return View();
    }

    [HttpPost]
    public ActionResult SaveReservation(string name, DateTime reservedDate, string timeReserved)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var reservation = new Reservation()
          {
            Name = name,
            ReservationDate = reservedDate,
            ReservationTime = timeReserved
          };
          db.Reservations.Add(reservation);
          db.SaveChanges();
          Response.StatusCode = 200;
          return View("Index");
        }
        return View("Index");
      }
      catch (Exception)
      {
        return View("Error");
      }

    }
  }
}