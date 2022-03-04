namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hashsalt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lawyers", "Salt", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lawyers", "Salt");
        }
    }
}
