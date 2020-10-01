namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedbmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genrs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Movies", "GenrId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenrId");
            AddForeignKey("dbo.Movies", "GenrId", "dbo.Genrs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenrId", "dbo.Genrs");
            DropIndex("dbo.Movies", new[] { "GenrId" });
            AlterColumn("dbo.Movies", "GenrId", c => c.Byte(nullable: false));
            DropTable("dbo.Genrs");
        }
    }
}
