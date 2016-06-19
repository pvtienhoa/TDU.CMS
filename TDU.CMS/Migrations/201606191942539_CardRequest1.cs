namespace TDU.CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardRequest1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CardRequests", "CardNumber", c => c.String(maxLength: 30));
            AlterColumn("dbo.CardRequests", "CardHolder", c => c.String(maxLength: 30));
            AlterColumn("dbo.CardRequests", "Cif", c => c.String(maxLength: 9));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CardRequests", "Cif", c => c.String(nullable: false, maxLength: 9));
            AlterColumn("dbo.CardRequests", "CardHolder", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.CardRequests", "CardNumber", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
