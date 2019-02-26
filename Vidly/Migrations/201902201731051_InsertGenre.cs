namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Comedy'),('Action'),('Family'),('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
