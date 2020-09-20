namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes(ID,signupfee,DurationInmonth,DiscountRate) values(1,0,0,0)");
            Sql("insert into MembershipTypes(ID,signupfee,DurationInmonth,DiscountRate) values(2,300,6,10)");
            Sql("insert into MembershipTypes(ID,signupfee,DurationInmonth,DiscountRate) values(3,500,8,20)");
            Sql("insert into MembershipTypes(ID,signupfee,DurationInmonth,DiscountRate) values(4,600,12,30)");

        }
        
        public override void Down()
        {
        }
    }
}
