using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Range.Models
{
  public class RangeContext : DbContext
  {
    public DbSet<Manufacturer> Manufacturer {get;set;}
    public DbSet<Reservation> Reservations { get; set; }

    public DbSet<Guns> Guns { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      Database.SetInitializer<RangeContext>(null);
      base.OnModelCreating(modelBuilder);
    }
  }
}