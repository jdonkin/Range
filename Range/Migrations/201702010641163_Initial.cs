namespace Range.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Guns", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Guns", "Maker_Id", "dbo.Manufacturers");
            DropIndex("dbo.Guns", new[] { "Maker_Id" });
            DropIndex("dbo.Guns", new[] { "Reservation_Id" });
            RenameColumn(table: "dbo.Guns", name: "Maker_Id", newName: "ManufacturerId");
            AddColumn("dbo.Reservations", "ReservationTime", c => c.String());
            AddColumn("dbo.Reservations", "Name", c => c.String());
            AlterColumn("dbo.Guns", "ManufacturerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Guns", "ManufacturerId");
            AddForeignKey("dbo.Guns", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
            DropColumn("dbo.Guns", "Reservation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guns", "Reservation_Id", c => c.Int());
            DropForeignKey("dbo.Guns", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Guns", new[] { "ManufacturerId" });
            AlterColumn("dbo.Guns", "ManufacturerId", c => c.Int());
            DropColumn("dbo.Reservations", "Name");
            DropColumn("dbo.Reservations", "ReservationTime");
            RenameColumn(table: "dbo.Guns", name: "ManufacturerId", newName: "Maker_Id");
            CreateIndex("dbo.Guns", "Reservation_Id");
            CreateIndex("dbo.Guns", "Maker_Id");
            AddForeignKey("dbo.Guns", "Maker_Id", "dbo.Manufacturers", "Id");
            AddForeignKey("dbo.Guns", "Reservation_Id", "dbo.Reservations", "Id");
        }
    }
}
