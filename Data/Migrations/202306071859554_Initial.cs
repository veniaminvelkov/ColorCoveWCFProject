namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRegistered = c.DateTime(nullable: false),
                        Username = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(maxLength: 15),
                        IsSoftDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateHired = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                        Username = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(maxLength: 15),
                        IsSoftDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        PaintId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DateOrdered = c.DateTime(nullable: false),
                        OrderDetails = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Paints", t => t.PaintId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.PaintId);
            
            CreateTable(
                "dbo.Paints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaintType = c.Int(nullable: false),
                        Brand = c.String(nullable: false, maxLength: 20),
                        Price = c.Double(nullable: false),
                        AdditionalInfo = c.String(maxLength: 120),
                        IsAvailable = c.Boolean(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "PaintId", "dbo.Paints");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "PaintId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Paints");
            DropTable("dbo.Orders");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
