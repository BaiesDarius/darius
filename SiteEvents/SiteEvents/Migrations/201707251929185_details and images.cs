namespace SiteEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class detailsandimages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Detalis", c => c.String());
            AddColumn("dbo.Events", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Image");
            DropColumn("dbo.Events", "Detalis");
        }
    }
}
