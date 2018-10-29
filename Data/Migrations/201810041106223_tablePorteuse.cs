namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablePorteuse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        ProductFk = c.Int(nullable: false),
                        ClientFk = c.String(nullable: false, maxLength: 128),
                        DateFacture = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductFk, t.ClientFk, t.DateFacture })
                .ForeignKey("dbo.Clients", t => t.ClientFk, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductFk, cascadeDelete: true)
                .Index(t => t.ProductFk)
                .Index(t => t.ClientFk);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 128),
                        Nom = c.String(),
                        Prenom = c.String(),
                    })
                .PrimaryKey(t => t.CIN);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factures", "ProductFk", "dbo.Products");
            DropForeignKey("dbo.Factures", "ClientFk", "dbo.Clients");
            DropIndex("dbo.Factures", new[] { "ClientFk" });
            DropIndex("dbo.Factures", new[] { "ProductFk" });
            DropTable("dbo.Clients");
            DropTable("dbo.Factures");
        }
    }
}
