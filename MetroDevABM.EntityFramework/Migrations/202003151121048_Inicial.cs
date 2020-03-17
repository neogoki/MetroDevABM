namespace MetroDevABM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        ClientTypeId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientTypes", t => t.ClientTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.ClientTypeId)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.ClientTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Clients", "ClientTypeId", "dbo.ClientTypes");
            DropIndex("dbo.Clients", new[] { "GenderId" });
            DropIndex("dbo.Clients", new[] { "ClientTypeId" });
            DropTable("dbo.Genders");
            DropTable("dbo.ClientTypes");
            DropTable("dbo.Clients");
        }
    }
}
