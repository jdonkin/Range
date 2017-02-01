using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Range.Models
{
  public class Guns
  {
    public int Id { get; set; }
    public int ManufacturerId { get; set; }
    public Manufacturer Manufacturer { get; set; }
    public string ModelName { get; set; }
    public int MagazineCapacity { get; set; }
    public string Caliber { get; set; }
    public string ImageLocation { get; set; }
  }
}