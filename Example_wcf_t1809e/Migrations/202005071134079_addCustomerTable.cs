namespace Example_wcf_t1809e.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        SecurityCode = c.String(),
                        Name = c.String(),
                        CurrentMoney = c.Double(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
