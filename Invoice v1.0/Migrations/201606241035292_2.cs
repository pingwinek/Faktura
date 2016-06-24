namespace Invoice_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DaneDoFakturies", "Name", c => c.String(maxLength: 30));
            AlterColumn("dbo.DaneDoFakturies", "Surname", c => c.String(maxLength: 30));
            AlterColumn("dbo.DaneDoFakturies", "City", c => c.String(maxLength: 30));
            AlterColumn("dbo.DaneDoFakturies", "Street", c => c.String(maxLength: 30));
            AlterColumn("dbo.DaneDoFakturies", "Product", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DaneDoFakturies", "Product", c => c.String());
            AlterColumn("dbo.DaneDoFakturies", "Street", c => c.String());
            AlterColumn("dbo.DaneDoFakturies", "City", c => c.String());
            AlterColumn("dbo.DaneDoFakturies", "Surname", c => c.String());
            AlterColumn("dbo.DaneDoFakturies", "Name", c => c.String());
        }
    }
}
