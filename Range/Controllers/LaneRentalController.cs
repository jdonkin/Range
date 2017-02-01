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

    [HttpPost]
    public ActionResult SaveReservation()
    {
      throw new NotImplementedException();
    }
  }
}