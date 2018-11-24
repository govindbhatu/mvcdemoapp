namespace MVC_Demo_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionAndDataForGenre : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.GenreTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.GenreTypes", "Id");

            
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.GenreTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.GenreTypes", "Id");
        }
    }
}
