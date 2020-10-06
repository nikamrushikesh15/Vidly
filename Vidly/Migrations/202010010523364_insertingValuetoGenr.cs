namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertingValuetoGenr : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT GENRS ON");
            Sql("insert into dbo.GENRS(Id,name) VALUES(1,'Comedy')");
            Sql("insert into dbo.GENRS(Id,name) VALUES(2,'Drama')");
            Sql("insert into dbo.GENRS(Id,name) VALUES(3,'Fear')");
    
        }
        
        public override void Down()
        {
        }
    }
}
