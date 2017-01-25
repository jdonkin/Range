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
    public string Caliber { get; set; }
    public byte[] Image { get; set; }
  }
}