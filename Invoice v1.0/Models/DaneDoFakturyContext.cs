using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class DaneDoFakturyContext : DbContext
    {
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Sprzedawca> Sprzedawca { get; set; }
        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Faktura> Faktura { get; set; }
        public DbSet<Najem> Najem { get; set; }
        public DbSet<Platnosc> Platnosc { get; set; }
        public DbSet<Sprzedawca_Klient> Sprzedawca_Klient { get; set; }
        public DbSet<Produkt_Klient> Produkt_Klient { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}