namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths,  DiscountRate) VALUES (1, 0, 1, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths,  DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths,  DiscountRate) VALUES (3, 90, 1, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths,  DiscountRate) VALUES (4, 300, 1, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
