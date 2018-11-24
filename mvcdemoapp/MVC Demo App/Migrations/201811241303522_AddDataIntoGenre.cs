namespace MVC_Demo_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataIntoGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into GenreTypes(Name) Values('Action')");
            Sql("Insert Into GenreTypes(Name) Values('Comedy')");
            Sql("Insert Into GenreTypes(Name) Values('Family')");
            Sql("Insert Into GenreTypes(Name) Values('Romantic')");
        }
        
        public override void Down()
        {
        }
    }
}
