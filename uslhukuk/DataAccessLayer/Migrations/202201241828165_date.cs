namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogTarihi");
        }
    }
}
