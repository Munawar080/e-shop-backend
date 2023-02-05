namespace E_ShopBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredContraintToCategoriesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 255));
        }
    }
}
