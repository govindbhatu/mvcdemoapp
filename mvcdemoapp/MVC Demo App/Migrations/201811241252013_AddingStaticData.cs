namespace MVC_Demo_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingStaticData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values(1,'Pay as You Go',0,0,0)");
            Sql("Insert Into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values(2,'Monthly',30,1,10)");
            Sql("Insert Into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values(3,'Quaterly',90,3,15)");
            Sql("Insert Into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) Values(4,'Yearly',300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
