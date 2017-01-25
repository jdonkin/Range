﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Range.Models
{
  public class Reservation
  {
    public int Id { get; set; }
    public DateTime ReservationDate { get; set; }
    public List<Guns> GunsToReserve { get; set; }
  }
}