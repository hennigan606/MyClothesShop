namespace MyClothesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBasket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Basket_Id", c => c.Int());
            CreateIndex("dbo.Products", "Basket_Id");
            AddForeignKey("dbo.Products", "Basket_Id", "dbo.Baskets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Basket_Id", "dbo.Baskets");
            DropIndex("dbo.Products", new[] { "Basket_Id" });
            DropColumn("dbo.Products", "Basket_Id");
            DropTable("dbo.Baskets");
        }
    }
}
