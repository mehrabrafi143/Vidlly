namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDiscountRateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "DiscoutRate", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "DiscoutRate");
        }
    }
}
