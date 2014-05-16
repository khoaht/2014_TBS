namespace TDevs.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tickets", "Message");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Message", c => c.String());
        }
    }
}
