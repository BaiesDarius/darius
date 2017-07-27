namespace SiteEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spellingerror : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Details", c => c.String());
            DropColumn("dbo.Events", "Detalis");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Detalis", c => c.String());
            DropColumn("dbo.Events", "Details");
        }
    }
}
