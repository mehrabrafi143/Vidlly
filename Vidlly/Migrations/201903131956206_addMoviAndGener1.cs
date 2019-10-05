namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoviAndGener1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DayOfAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "PublishDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "RealiseDate");
            DropColumn("dbo.Movies", "PublishDate_RelationName");
            DropColumn("dbo.Movies", "PublishDate_Nested");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "PublishDate_Nested", c => c.Boolean(nullable: false));
            AddColumn("dbo.Movies", "PublishDate_RelationName", c => c.String());
            AddColumn("dbo.Movies", "RealiseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "PublishDate");
            DropColumn("dbo.Movies", "DayOfAdded");
        }
    }
}
