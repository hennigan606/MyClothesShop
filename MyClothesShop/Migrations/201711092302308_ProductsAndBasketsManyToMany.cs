namespace MyClothesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductsAndBasketsManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "BasketModel_BasketID", "dbo.BasketModels");
            DropIndex("dbo.Products", new[] { "BasketModel_BasketID" });
            CreateTable(
                "dbo.ProductBasketModels",
                c => new
                    {
                        Product_ProductID = c.Int(nullable: false),
                        BasketModel_BasketID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ProductID, t.BasketModel_BasketID })
                .ForeignKey("dbo.Products", t => t.Product_ProductID, cascadeDelete: true)
                .ForeignKey("dbo.BasketModels", t => t.BasketModel_BasketID, cascadeDelete: true)
                .Index(t => t.Product_ProductID)
                .Index(t => t.BasketModel_BasketID);
            
            DropColumn("dbo.Products", "BasketModel_BasketID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "BasketModel_BasketID", c => c.Int());
            DropForeignKey("dbo.ProductBasketModels", "BasketModel_BasketID", "dbo.BasketModels");
            DropForeignKey("dbo.ProductBasketModels", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.ProductBasketModels", new[] { "BasketModel_BasketID" });
            DropIndex("dbo.ProductBasketModels", new[] { "Product_ProductID" });
            DropTable("dbo.ProductBasketModels");
            CreateIndex("dbo.Products", "BasketModel_BasketID");
            AddForeignKey("dbo.Products", "BasketModel_BasketID", "dbo.BasketModels", "BasketID");
        }
    }
}
