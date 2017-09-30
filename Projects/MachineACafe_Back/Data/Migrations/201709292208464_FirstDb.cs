namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoffeOrders",
                c => new
                    {
                        badge = c.String(nullable: false, maxLength: 128),
                        type = c.String(),
                        personalCup = c.Boolean(nullable: false),
                        sugarQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.badge);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoffeOrders");
        }
    }
}
