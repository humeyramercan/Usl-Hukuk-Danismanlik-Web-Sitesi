namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uzmanlikalanlari : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreasOfExpertises",
                c => new
                    {
                        UzmanlikAlaniID = c.Int(nullable: false, identity: true),
                        UzmanlikAlaniBaslik = c.String(),
                        İcerik = c.String(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.UzmanlikAlaniID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AreasOfExpertises");
        }
    }
}
