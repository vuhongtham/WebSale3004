namespace WebSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tham : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "UpdatedBy");
        }
    }
}
