namespace Invoice_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startowa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faktura",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NrFaktury = c.String(),
                        KlientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Klient", t => t.KlientID)
                .Index(t => t.KlientID);
            
            CreateTable(
                "dbo.Klient",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Ulica = c.String(),
                        NrDomu = c.Int(nullable: false),
                        Miasto = c.String(),
                        NIP = c.String(),
                        PlatnoscID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Platnosc", t => t.PlatnoscID)
                .Index(t => t.PlatnoscID);
            
            CreateTable(
                "dbo.Konto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NrKonta = c.Long(nullable: false),
                        Bank = c.String(),
                        KlientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Klient", t => t.KlientID)
                .Index(t => t.KlientID);
            
            CreateTable(
                "dbo.Najem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NrNajmu = c.String(),
                        KlientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Klient", t => t.KlientID)
                .Index(t => t.KlientID);
            
            CreateTable(
                "dbo.Platnosc",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SposobPlatnosci = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Produkt_Klient",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProduktID = c.Int(nullable: false),
                        KlientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Klient", t => t.KlientID)
                .ForeignKey("dbo.Produkt", t => t.ProduktID)
                .Index(t => t.ProduktID)
                .Index(t => t.KlientID);
            
            CreateTable(
                "dbo.Produkt",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        CenaNettoZaSzt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ilosc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sprzedawca_Klient",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SprzedawcaID = c.Int(nullable: false),
                        KlientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Klient", t => t.KlientID)
                .ForeignKey("dbo.Sprzedawca", t => t.SprzedawcaID)
                .Index(t => t.SprzedawcaID)
                .Index(t => t.KlientID);
            
            CreateTable(
                "dbo.Sprzedawca",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Ulica = c.String(),
                        NrDomu = c.Int(nullable: false),
                        Miasto = c.String(),
                        NIP = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sprzedawca_Klient", "SprzedawcaID", "dbo.Sprzedawca");
            DropForeignKey("dbo.Sprzedawca_Klient", "KlientID", "dbo.Klient");
            DropForeignKey("dbo.Produkt_Klient", "ProduktID", "dbo.Produkt");
            DropForeignKey("dbo.Produkt_Klient", "KlientID", "dbo.Klient");
            DropForeignKey("dbo.Klient", "PlatnoscID", "dbo.Platnosc");
            DropForeignKey("dbo.Najem", "KlientID", "dbo.Klient");
            DropForeignKey("dbo.Konto", "KlientID", "dbo.Klient");
            DropForeignKey("dbo.Faktura", "KlientID", "dbo.Klient");
            DropIndex("dbo.Sprzedawca_Klient", new[] { "KlientID" });
            DropIndex("dbo.Sprzedawca_Klient", new[] { "SprzedawcaID" });
            DropIndex("dbo.Produkt_Klient", new[] { "KlientID" });
            DropIndex("dbo.Produkt_Klient", new[] { "ProduktID" });
            DropIndex("dbo.Najem", new[] { "KlientID" });
            DropIndex("dbo.Konto", new[] { "KlientID" });
            DropIndex("dbo.Klient", new[] { "PlatnoscID" });
            DropIndex("dbo.Faktura", new[] { "KlientID" });
            DropTable("dbo.Sprzedawca");
            DropTable("dbo.Sprzedawca_Klient");
            DropTable("dbo.Produkt");
            DropTable("dbo.Produkt_Klient");
            DropTable("dbo.Platnosc");
            DropTable("dbo.Najem");
            DropTable("dbo.Konto");
            DropTable("dbo.Klient");
            DropTable("dbo.Faktura");
        }
    }
}
