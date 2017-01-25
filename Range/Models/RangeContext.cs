using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Range.Models
{
  public class RangeContext : DbContext
  {
    public IDbSet<Manufacturer> Manufacturer {get;set;}
    public IDbSet<Guns> Gun { get; set; }
  }
}