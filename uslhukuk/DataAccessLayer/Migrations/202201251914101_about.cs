namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class about : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        HakkimizdaID = c.Int(nullable: false, identity: true),
                        İcerik = c.String(),
                    })
                .PrimaryKey(t => t.HakkimizdaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
