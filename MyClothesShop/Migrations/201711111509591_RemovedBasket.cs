namespace MyClothesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedBasket : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductBasketModels", "Product_ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductBasketModels", "BasketModel_BasketID", "dbo.BasketModels");
            DropIndex("dbo.ProductBasketModels", new[] { "Product_ProductID" });
            DropIndex("dbo.ProductBasketModels", new[] { "BasketModel_BasketID" });
            AddColumn("dbo.Products", "BasketID", c => c.Int(nullable: false));
            DropTable("dbo.BasketModels");
            DropTable("dbo.ProductBasketModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductBasketModels",
                c => new
                    {
                        Product_ProductID = c.Int(nullable: false),
                        BasketModel_BasketID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ProductID, t.BasketModel_BasketID });
            
            CreateTable(
                "dbo.BasketModels",
                c => new
                    {
                        BasketID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BasketID);
            
            DropColumn("dbo.Products", "BasketID");
            CreateIndex("dbo.ProductBasketModels", "BasketModel_BasketID");
            CreateIndex("dbo.ProductBasketModels", "Product_ProductID");
            AddForeignKey("dbo.ProductBasketModels", "BasketModel_BasketID", "dbo.BasketModels", "BasketID", cascadeDelete: true);
            AddForeignKey("dbo.ProductBasketModels", "Product_ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
        }
    }
}
