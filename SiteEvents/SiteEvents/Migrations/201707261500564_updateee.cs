namespace SiteEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateee : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comments", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Author", c => c.String());
        }
    }
}
