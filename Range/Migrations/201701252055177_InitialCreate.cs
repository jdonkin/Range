namespace Range.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                        MagazineCapacity = c.Int(nullable: false),
                        Caliber = c.String(),
                        ImageLocation = c.String(),
                        Maker_Id = c.Int(),
                        Reservation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.Maker_Id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .Index(t => t.Maker_Id)
                .Index(t => t.Reservation_Id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guns", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Guns", "Maker_Id", "dbo.Manufacturers");
            DropIndex("dbo.Guns", new[] { "Reservation_Id" });
            DropIndex("dbo.Guns", new[] { "Maker_Id" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Guns");
        }
    }
}
