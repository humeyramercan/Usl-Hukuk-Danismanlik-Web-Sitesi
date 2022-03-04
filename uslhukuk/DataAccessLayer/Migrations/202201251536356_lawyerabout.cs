namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lawyerabout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lawyers", "Hakkinda", c => c.String());
            DropColumn("dbo.Lawyers", "Hakkında");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lawyers", "Hakkında", c => c.String());
            DropColumn("dbo.Lawyers", "Hakkinda");
        }
    }
}
