namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = convert(datetime,'01.01.2019',105) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
