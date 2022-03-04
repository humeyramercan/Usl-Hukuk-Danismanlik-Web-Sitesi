namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kullanici : DbMigration
    {
        public override void Up()
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
            
            DropTable("dbo.Lawyers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Lawyers",
                c => new
                    {
                        LawyerID = c.Int(nullable: false, identity: true),
                        LawyerUserName = c.String(),
                        LawyerPassword = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.LawyerID);
            
            DropTable("dbo.Kullanicis");
        }
    }
}
