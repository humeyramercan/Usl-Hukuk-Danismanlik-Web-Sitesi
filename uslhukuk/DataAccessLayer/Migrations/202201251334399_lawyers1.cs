namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lawyers1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lawyers",
                c => new
                    {
                        AvukatID = c.Int(nullable: false, identity: true),
                        UnvanAdSoyad = c.String(),
                        Hakkında = c.String(),
                        Resim = c.String(),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.AvukatID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lawyers");
        }
    }
}
