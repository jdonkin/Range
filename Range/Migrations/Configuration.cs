namespace Range.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;
  using Models;

  internal sealed class Configuration : DbMigrationsConfiguration<Range.Models.RangeContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
      ContextKey = "Range.Models.RangeContext";
    }

    protected override void Seed(Range.Models.RangeContext context)
    {
      context.Manufacturer.AddOrUpdate(x => x.Id,
        new Manufacturer { Id = 1, Name = "Beretta", Url = "http://www.beretta.com/en-us/" },
        new Manufacturer { Id = 2, Name = "Glock", Url = "https://us.glock.com/products/model/" },
        new Manufacturer { Id = 3, Name = "FN", Url = "https://fnamerica.com/products/pistols/" }
        );

      context.Guns.AddOrUpdate(x => x.Id,
        new Guns { Id = 1, Caliber = "9mm", ImageLocation = "http://localhost:4877/Content/Images/Manufacturers/Beretta/92FS.jpg", MagazineCapacity = 15, ManufacturerId = 1, ModelName = "92-fs" },
        new Guns { Id = 2, Caliber = "40 S&W", ImageLocation = "http://localhost:4877/Content/Images/Manufacturers/Glock/Glock22.jpg", MagazineCapacity = 15, ManufacturerId = 2, ModelName = "G22Gen4" },
        new Guns { Id = 3, Caliber = "45 ACP", ModelName = "FNX-45", ImageLocation = "http://localhost:4877/Content/Images/Manufacturers/FN/fnx-45.jpg", MagazineCapacity = 15, ManufacturerId = 3 }
        );
    }
  }
}
