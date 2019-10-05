namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmovieIdandCustomerID : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Rentals", name: "Customer_Id", newName: "CustomerId");
            RenameColumn(table: "dbo.Rentals", name: "Movie_Id", newName: "MovieId");
            RenameIndex(table: "dbo.Rentals", name: "IX_Customer_Id", newName: "IX_CustomerId");
            RenameIndex(table: "dbo.Rentals", name: "IX_Movie_Id", newName: "IX_MovieId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Rentals", name: "IX_MovieId", newName: "IX_Movie_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_CustomerId", newName: "IX_Customer_Id");
            RenameColumn(table: "dbo.Rentals", name: "MovieId", newName: "Movie_Id");
            RenameColumn(table: "dbo.Rentals", name: "CustomerId", newName: "Customer_Id");
        }
    }
}
