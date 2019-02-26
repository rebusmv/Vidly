namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES ('Hangover',1,'01.01.2019',5)");
            Sql("INSERT INTO Movies VALUES ('DieHard',2,'12.03.2007',10)");
            Sql("INSERT INTO Movies VALUES ('The Terminator',2,'07.11.1990',0)");
            Sql("INSERT INTO Movies VALUES ('Toy Story',3,'03.04.2012',1)");
            Sql("INSERT INTO Movies VALUES ('Titanic',4,'23.02.2017',2)");

        }
        
        public override void Down()
        {
        }
    }
}
