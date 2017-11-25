namespace MyClothesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedBasketFieldsAndProductID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Basket_Id", "dbo.Baskets");
            DropIndex("dbo.Products", new[] { "Basket_Id" });
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "Id");
            DropColumn("dbo.Products", "Basket_Id");
            DropTable("dbo.Baskets");
            CreateTable(
                "dbo.BasketModels",
                c => new
                    {
                        BasketID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BasketID);
            
            AddColumn("dbo.Products", "ProductID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Products", "BasketModel_BasketID", c => c.Int());
            AddPrimaryKey("dbo.Products", "ProductID");
            CreateIndex("dbo.Products", "BasketModel_BasketID");
            AddForeignKey("dbo.Products", "BasketModel_BasketID", "dbo.BasketModels", "BasketID");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Basket_Id", c => c.Int());
            AddColumn("dbo.Products", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Products", "BasketModel_BasketID", "dbo.BasketModels");
            DropIndex("dbo.Products", new[] { "BasketModel_BasketID" });
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "BasketModel_BasketID");
            DropColumn("dbo.Products", "ProductID");
            DropTable("dbo.BasketModels");
            AddPrimaryKey("dbo.Products", "Id");
            CreateIndex("dbo.Products", "Basket_Id");
            AddForeignKey("dbo.Products", "Basket_Id", "dbo.Baskets", "Id");
        }
    }
}
