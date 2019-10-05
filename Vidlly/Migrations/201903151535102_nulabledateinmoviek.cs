namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nulabledateinmoviek : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DayOfAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DayOfAdded", c => c.DateTime(nullable: false));
        }
    }
}
