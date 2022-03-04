namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lawyers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lawyers",
                c => new
                    {
                        LawyerID = c.Int(nullable: false, identity: true),
                        LawyerUserName = c.String(),
                        LawyerPassword = c.String(),
                    })
                .PrimaryKey(t => t.LawyerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lawyers");
        }
    }
}
