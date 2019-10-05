namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPriceToMembersip : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "Price");
        }
    }
}
