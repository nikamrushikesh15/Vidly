namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedidtoautoincreament : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movie ADD Id int NOT NULL AUTO_INCREMENT PRIMARY KEY");
            Sql("ALTER TABLE movies ADD Id INT NOT NULL AUTO_INCREMENT int unique");

        }

        public override void Down()
        {
        }
    }
}
