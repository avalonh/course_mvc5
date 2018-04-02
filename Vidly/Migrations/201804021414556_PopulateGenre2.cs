namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreName) VALUES('Comedy')");
            Sql("INSERT INTO Genres (GenreName) VALUES('Science Fiction')");
            Sql("INSERT INTO Genres (GenreName) VALUES('Horror')");
            Sql("INSERT INTO Genres (GenreName) VALUES('Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
