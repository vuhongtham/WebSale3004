namespace WebSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteUpdatedDateAtProductTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "UpdatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "UpdatedBy", c => c.String());
        }
    }
}
