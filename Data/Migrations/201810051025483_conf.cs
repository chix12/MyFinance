namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conf : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            RenameTable(name: "dbo.ProviderProducts", newName: "Provindings");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            RenameColumn(table: "dbo.Provindings", name: "Provider_Providerkey", newName: "ProviderId");
            RenameColumn(table: "dbo.Provindings", name: "Product_ProductId", newName: "ProductId");
            RenameIndex(table: "dbo.Provindings", name: "IX_Product_ProductId", newName: "IX_ProductId");
            RenameIndex(table: "dbo.Provindings", name: "IX_Provider_Providerkey", newName: "IX_ProviderId");
            DropPrimaryKey("dbo.Provindings");
            AddColumn("dbo.Products", "IsBiological", c => c.Int());
            AlterColumn("dbo.MyCategories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Adresse_StreetAddres", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Provindings", new[] { "ProductId", "ProviderId" });
            CreateIndex("dbo.Products", "CategoryId");
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Provindings");
            AlterColumn("dbo.Products", "Adresse_StreetAddres", c => c.String());
            AlterColumn("dbo.Products", "CategoryId", c => c.Int());
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            DropColumn("dbo.Products", "IsBiological");
            AddPrimaryKey("dbo.Provindings", new[] { "Provider_Providerkey", "Product_ProductId" });
            RenameIndex(table: "dbo.Provindings", name: "IX_ProviderId", newName: "IX_Provider_Providerkey");
            RenameIndex(table: "dbo.Provindings", name: "IX_ProductId", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Provindings", name: "ProductId", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Provindings", name: "ProviderId", newName: "Provider_Providerkey");
            CreateIndex("dbo.Products", "CategoryId");
            RenameTable(name: "dbo.Provindings", newName: "ProviderProducts");
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
        }
    }
}
