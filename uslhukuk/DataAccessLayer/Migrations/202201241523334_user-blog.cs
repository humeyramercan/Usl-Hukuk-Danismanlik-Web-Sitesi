namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userblog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.Blogs", "BlogTitle", c => c.String());
            AddColumn("dbo.Blogs", "BlogAuthor", c => c.String());
            AddColumn("dbo.Blogs", "BlogContent", c => c.String());
            DropColumn("dbo.Blogs", "BlogBasligi");
            DropColumn("dbo.Blogs", "BlogYazari");
            DropColumn("dbo.Blogs", "Blogİcerigi");
            DropTable("dbo.Kullanicis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
            AddColumn("dbo.Blogs", "Blogİcerigi", c => c.String());
            AddColumn("dbo.Blogs", "BlogYazari", c => c.String());
            AddColumn("dbo.Blogs", "BlogBasligi", c => c.String());
            DropColumn("dbo.Blogs", "BlogContent");
            DropColumn("dbo.Blogs", "BlogAuthor");
            DropColumn("dbo.Blogs", "BlogTitle");
            DropTable("dbo.Users");
        }
    }
}
