namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Baslik", c => c.String());
            AddColumn("dbo.Blogs", "Yazar", c => c.String());
            AddColumn("dbo.Blogs", "İcerik", c => c.String());
            DropColumn("dbo.Blogs", "BlogTitle");
            DropColumn("dbo.Blogs", "BlogAuthor");
            DropColumn("dbo.Blogs", "BlogContent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "BlogContent", c => c.String());
            AddColumn("dbo.Blogs", "BlogAuthor", c => c.String());
            AddColumn("dbo.Blogs", "BlogTitle", c => c.String());
            DropColumn("dbo.Blogs", "İcerik");
            DropColumn("dbo.Blogs", "Yazar");
            DropColumn("dbo.Blogs", "Baslik");
        }
    }
}
