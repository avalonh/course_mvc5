namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeDescription : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeDescription = 'Pay as you go' WHERE Id = 1 ");
            Sql("UPDATE MembershipTypes SET TypeDescription = 'Monthly' WHERE Id = 2 ");
            Sql("UPDATE MembershipTypes SET TypeDescription = 'Quarterly' WHERE Id = 3 ");
            Sql("UPDATE MembershipTypes SET TypeDescription = 'Yearly' WHERE Id = 4 ");
        }
        
        public override void Down()
        {
        }
    }
}
