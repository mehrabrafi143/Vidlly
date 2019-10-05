namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingcustomerrolemanager : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c2f87c57-8bb0-44b3-9e8c-d28c5419e1b9', N'customerAdmin@vidly.com', 0, N'ALK2IhJPcwZ56/zXKAidEkW7WhLW3mlI2LrQ+Zacp1rTuri9QthMGtFQ4RI50gZeeg==', N'c63130cf-5142-4908-96dd-eca2096600ea', NULL, 0, 0, NULL, 1, 0, N'customerAdmin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2af7ee4f-edd6-4ae1-898f-d5ecc0570999', N'CanManageCustomers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'848749b8-f987-43a1-a0a6-09c30bedc452', N'7769f5ff-f681-4fb4-8841-7adbfacb7fab')

");
        }
        
        public override void Down()
        {
        }
    }
}
