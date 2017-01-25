using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Range.Models
{
  public class Guns
  {
    public int Id { get; set; }
    public Manufacturer Maker { get; set; }
    public string ModelName { get; set; }
    public int MagazineCapacity { get; set; }
    public string Caliber { get; set; }
    public string ImageLocation { get; set; }
  }
}