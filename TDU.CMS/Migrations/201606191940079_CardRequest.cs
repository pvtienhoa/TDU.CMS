namespace TDU.CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardRequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardRequests",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CardNumber = c.String(nullable: false, maxLength: 30),
                        CardHolder = c.String(nullable: false, maxLength: 30),
                        Cif = c.String(nullable: false, maxLength: 9),
                        Type = c.Int(nullable: false),
                        RequestDate = c.DateTime(nullable: false),
                        CardLocation = c.Int(nullable: false),
                        PinLocation = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        EmployeeName = c.String(maxLength: 50),
                        Code = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CardNumber = c.String(nullable: false, maxLength: 30),
                        CardHolder = c.String(nullable: false, maxLength: 30),
                        IssueDate = c.DateTime(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        Cif = c.String(nullable: false, maxLength: 9),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.Int(nullable: false),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                        TellerID = c.String(nullable: false, maxLength: 6),
                        Name = c.String(),
                        DeptID = c.Long(nullable: false),
                        Department_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
            CreateTable(
                "dbo.RequestHistories",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CardID = c.Long(nullable: false),
                        Description = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cards", t => t.CardID, cascadeDelete: true)
                .Index(t => t.CardID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequestHistories", "CardID", "dbo.Cards");
            DropForeignKey("dbo.Employees", "Department_ID", "dbo.Departments");
            DropIndex("dbo.RequestHistories", new[] { "CardID" });
            DropIndex("dbo.Employees", new[] { "Department_ID" });
            DropTable("dbo.RequestHistories");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Cards");
            DropTable("dbo.CardRequests");
        }
    }
}
