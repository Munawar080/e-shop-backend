namespace E_ShopBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyConstraintIntoCategoriesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
