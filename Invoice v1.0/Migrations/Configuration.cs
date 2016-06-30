namespace Invoice_v1._0.Migrations
{
    using Invoice_v1._0.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Invoice_v1._0.Models.DaneDoFakturyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            if (System.Diagnostics.Debugger.IsAttached == false)
                System.Diagnostics.Debugger.Launch();

            SeedPlatnosc(context);
            SeedKlient(context);
            SeedSprzedawca(context);
            SeedKonto(context);
            SeedFaktura(context);
            SeedNajem(context);
            SeedSprzedawca_Klient(context);
            //SeedProdukt_Klient(context);

        }

        private void SeedSprzedawca(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var sprzedawca = new Sprzedawca()
            {
                ID = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Ulica = "Poprzeczna",
                NrDomu = 43,
                Miasto = "Czêstochowa",
                NIP = "500262354"
            };
            context.Set<Sprzedawca>().AddOrUpdate(sprzedawca);
            context.SaveChanges();
        }

        private void SeedPlatnosc(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var platnosc = new Platnosc()
            {
                ID = 1,
                SposobPlatnosci = "przelew"
            };
            context.Set<Platnosc>().AddOrUpdate(platnosc);
            context.SaveChanges();
        }

        private void SeedKlient(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var IdPlatnosci = context.Set<Platnosc>().Where(p => p.ID == 1).FirstOrDefault().ID;

            var klient = new Klient()
            {
                ID = 1,
                Imie = "Adam",
                Nazwisko = "Nowak",
                Ulica = "Mi³a",
                NrDomu = 2,
                Miasto = "Wroc³aw",
                NIP = "001235689",
                PlatnoscID = IdPlatnosci
            };
            context.Set<Klient>().AddOrUpdate(klient);
            context.SaveChanges();
        }

        private void SeedSprzedawca_Klient(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var IdKlienta = context.Set<Klient>().Where(k => k.ID == 1).FirstOrDefault().ID;
            var IdSprzedawcy = context.Set<Sprzedawca>().Where(k => k.ID == 1).FirstOrDefault().ID;

            var sprzedawca_klient = new Sprzedawca_Klient()
            {
                ID = 1,
                KlientID = IdKlienta,
                SprzedawcaID = IdSprzedawcy
            };
            context.Set<Sprzedawca_Klient>().AddOrUpdate(sprzedawca_klient);
            context.SaveChanges();
        }

        private void SeedProdukt_Klient(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var produkt_klient = new Produkt_Klient()
            {
                ID = 1,
                KlientID = 1,
                ProduktID = 1
            };
            context.Set<Produkt_Klient>().AddOrUpdate(produkt_klient);
            context.SaveChanges();
        }

        private void SeedKonto(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var IdKlienta = context.Set<Klient>().Where(k => k.ID == 1).FirstOrDefault().ID;

            var konto = new Konto()
            {
                ID = 1,
                NrKonta = 123456789,
                Bank = "PKO BP",
                KlientID = IdKlienta
            };
            context.Set<Konto>().AddOrUpdate(konto);
            context.SaveChanges();
        }

        private void SeedFaktura(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var IdKlienta = context.Set<Klient>().Where(k => k.ID == 1).FirstOrDefault().ID;

            var faktura = new Faktura()
            {
                ID = 1,
                NrFaktury = "6/FV/2016",
                KlientID = IdKlienta

            };
            context.Set<Faktura>().AddOrUpdate(faktura);
            context.SaveChanges();
        }

        private void SeedNajem(Invoice_v1._0.Models.DaneDoFakturyContext context)
        {
            var IdKlienta = context.Set<Klient>().Where(k => k.ID == 1).FirstOrDefault().ID;

            var najem = new Najem()
            {
                ID = 1,
                NrNajmu = "6/UM/2016",
                KlientID = IdKlienta
            };
            context.Set<Najem>().AddOrUpdate(najem);
            context.SaveChanges();
        }
    }
}