namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "TypeDescription", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "TypeDescription");
        }
    }
}
