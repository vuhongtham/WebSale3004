namespace WebSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPriceColumnForOrderDetailTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetails", "Price");
        }
    }
}
