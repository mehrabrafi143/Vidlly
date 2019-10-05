namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingRoleMAnagers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'204f611b-c8dc-41a2-9f99-15aafdfa956a', N'adminMov@vidly.com', 0, N'AGfiDdkaWZsyXvQPsb1qM2l9DEhSyftpolc569nO+dDvhuk72k6+2XPeE8tiA4DeeA==', N'aac2bf61-f681-4c54-a36e-7ddf2f220b5a', NULL, 0, 0, NULL, 1, 0, N'adminMov@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8effc11f-41ed-4685-accf-5da1fc183af2', N'adminCus@vidly.com', 0, N'ALfEyY+ZvVfjlScQz7jm4zmcipwhazPa2yOdZGj4B5or1aG4FEkz+WhQsRultnHzrw==', N'83607572-cadc-49ae-8fb5-99136e157997', NULL, 0, 0, NULL, 1, 0, N'adminCus@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b266174a-c960-46fa-bbcf-62a1f93ea023', N'user!@vidly.com', 0, N'APibJH4P5CAoRosAyKyS56JeHAlALvWisvZyhn6JG9fhIBs7FIP22bn0oOtJY9donw==', N'630a7a91-8909-4394-9d11-28c0b60bb605', NULL, 0, 0, NULL, 1, 0, N'user!@vidly.com')



INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1689dfc-fc0c-4876-a5e5-2546ab98b3ee', N'CanManageCustomers')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a55869cc-54d0-46d7-aa93-60d26a200bae', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8effc11f-41ed-4685-accf-5da1fc183af2', N'a55869cc-54d0-46d7-aa93-60d26a200bae')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'204f611b-c8dc-41a2-9f99-15aafdfa956a', N'd1689dfc-fc0c-4876-a5e5-2546ab98b3ee')


");
        }
        
        public override void Down()
        {
        }
    }
}
