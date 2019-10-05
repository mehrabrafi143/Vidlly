namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intToStringNoteUserId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notes", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notes", "UserId", c => c.Int(nullable: false));
        }
    }
}
