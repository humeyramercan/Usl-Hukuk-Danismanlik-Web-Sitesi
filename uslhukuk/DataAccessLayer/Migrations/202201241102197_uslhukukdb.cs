namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uslhukukdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        BlogBasligi = c.String(),
                        BlogYazari = c.String(),
                        Blogİcerigi = c.String(),
                    })
                .PrimaryKey(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Blogs");
        }
    }
}
