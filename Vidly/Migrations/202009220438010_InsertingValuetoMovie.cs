namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingValuetoMovie : DbMigration
    {
        public override void Up()
        {
            
            Sql("SET IDENTITY_INSERT Movies ON; insert into Movies(Id,name,Genre,Date_Added,stock) values(1,'John','Comedy','2019/10/15',3)");
            Sql(" SET IDENTITY_INSERT Movies ON; insert into Movies(Id,name,Genre,Date_Added,stock) values(2,'harry','Drama','2018/10/15',4)");
            Sql(" SET IDENTITY_INSERT Movies ON; insert into Movies(Id,name,Genre,Date_Added,stock) values(3,'potter','Comedy','2020/10/20',1)");
            Sql(" SET IDENTITY_INSERT Movies ON; insert into Movies(Id,name,Genre,Date_Added,stock) values(4,'Smith','Horror','2015/10/15',3)");
            Sql(" SET IDENTITY_INSERT Movies ON; insert into Movies(Id,name,Genre,Date_Added,stock) values(5,'henry','Romantic','2016/10/15',10)");
        }
        
        public override void Down()
        {
        }
    }
}
