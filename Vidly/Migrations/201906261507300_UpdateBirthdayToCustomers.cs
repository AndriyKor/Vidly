namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdayToCustomers : DbMigration
    {
        public override void Up()
        {
            // Add Customers
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('Mario Balotelli', 0, 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('David de Gea', 1, 2)");

            Sql("UPDATE Customers SET Birthday = '12/13/1986' WHERE Id = 2");         
        }
        
        public override void Down()
        {
        }
    }
}
