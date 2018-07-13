namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWithMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES ('Hangover', 'Comedy', CAST('2009-06-12' AS DateTime), CAST('2018-07-13' AS DateTime), 5)");
            Sql("INSERT INTO Movies VALUES ('Die Hard', 'Action', CAST('1989-02-03' AS DateTime), CAST('2018-07-13' AS DateTime), 3)");
            Sql("INSERT INTO Movies VALUES ('The Terminator', 'Action', CAST('1985-01-11' AS DateTime), CAST('2018-07-13' AS DateTime), 2)");
            Sql("INSERT INTO Movies VALUES ('Toy Story', 'Family', CAST('1996-03-22' AS DateTime), CAST('2018-07-13' AS DateTime), 4)");
            Sql("INSERT INTO Movies VALUES ('Titanic', 'Romance', CAST('1997-11-18' AS DateTime), CAST('2018-07-13' AS DateTime), 3)");
        }
        
        public override void Down()
        {
        }
    }
}
