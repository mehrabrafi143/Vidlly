namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notes", "UserId");
        }
    }
}
