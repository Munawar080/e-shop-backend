namespace E_ShopBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryIdToProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "categoryId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "categoryId");
        }
    }
}
