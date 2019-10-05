namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'848749b8-f987-43a1-a0a6-09c30bedc452', N'admin@vidly.com', 0, N'APMaqbtZEqsp8g6Nph8MQMGg5waIMYvnH6SMnnPT4GebS3cxqFOXQr5qa7en+OU7WQ==', N'8b155a65-8411-4acd-841b-423b52b57fd5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c2ff26c-0712-4bc2-a3d4-d23d97a8a928', N'user@vidly.com', 0, N'AD4l5wf4sMezt8VInCQVoEF8gyeOnIR32K1KksPyyIp0Guw/4rDuLgSHQpUYeOogBg==', N'48fb6ff9-413e-420b-9ae6-b81d14cf15fa', NULL, 0, 0, NULL, 1, 0, N'user@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7769f5ff-f681-4fb4-8841-7adbfacb7fab', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'848749b8-f987-43a1-a0a6-09c30bedc452', N'7769f5ff-f681-4fb4-8841-7adbfacb7fab')



");
        }
        
        public override void Down()
        {
        }
    }
}
