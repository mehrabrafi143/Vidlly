namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoviAndGener : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Geners",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenerId = c.Byte(nullable: false),
                        RealiseDate = c.DateTime(nullable: false),
                        PublishDate_RelationName = c.String(),
                        PublishDate_Nested = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Geners", t => t.GenerId, cascadeDelete: true)
                .Index(t => t.GenerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenerId", "dbo.Geners");
            DropIndex("dbo.Movies", new[] { "GenerId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Geners");
        }
    }
}
