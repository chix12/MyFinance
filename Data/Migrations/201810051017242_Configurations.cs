namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Configurations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            RenameTable(name: "dbo.ProviderProducts", newName: "Providings");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            RenameColumn(table: "dbo.Providings", name: "Provider_ProviderKey", newName: "ProviderId");
            RenameColumn(table: "dbo.Providings", name: "Product_ProductId", newName: "ProductId");
            RenameIndex(table: "dbo.Providings", name: "IX_Product_ProductId", newName: "IX_ProductId");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider_ProviderKey", newName: "IX_ProviderId");
            DropPrimaryKey("dbo.Providings");
            AddColumn("dbo.Products", "IsBiological", c => c.Int());
            AddColumn("dbo.Products", "IsChemical", c => c.Int());
            AlterColumn("dbo.MyCategories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Adresse_StreetAddress", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Providings", new[] { "ProductId", "ProviderId" });
            CreateIndex("dbo.Products", "CategoryId");
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.Products", "Adresse_StreetAddress", c => c.String());
            AlterColumn("dbo.Products", "CategoryId", c => c.Int());
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            DropColumn("dbo.Products", "IsChemical");
            DropColumn("dbo.Products", "IsBiological");
            AddPrimaryKey("dbo.Providings", new[] { "Provider_ProviderKey", "Product_ProductId" });
            RenameIndex(table: "dbo.Providings", name: "IX_ProviderId", newName: "IX_Provider_ProviderKey");
            RenameIndex(table: "dbo.Providings", name: "IX_ProductId", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "ProductId", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "ProviderId", newName: "Provider_ProviderKey");
            CreateIndex("dbo.Products", "CategoryId");
            RenameTable(name: "dbo.Providings", newName: "ProviderProducts");
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
        }
    }
}
