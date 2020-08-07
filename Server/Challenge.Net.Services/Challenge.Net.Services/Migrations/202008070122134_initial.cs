namespace Challenge.Net.Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsSealPresent = c.Boolean(nullable: false),
                        IsHazard = c.Boolean(nullable: false),
                        IsDamaggeFound = c.Boolean(nullable: false),
                        Note = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Review");
        }
    }
}
