namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addissubscribedtoNewsletter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IssusbscribedtoNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IssusbscribedtoNewsletter");
        }
    }
}
