namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednullablecolumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Date_Added", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Date_Added", c => c.DateTime(nullable: false));
        }
    }
}
