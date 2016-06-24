namespace Invoice_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DaneDoFakturies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Gender = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        NumberOfAddress = c.Int(nullable: false),
                        Product = c.String(),
                        PriceForOne = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amounts = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DaneDoFakturies");
        }
    }
}
