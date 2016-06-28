using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Klient
    {
        public Klient()
        {
            this.Sprzedawca_Klient = new HashSet<Sprzedawca_Klient>();
            this.Produkt_Klient = new HashSet<Produkt_Klient>();
            this.Konto = new HashSet<Konto>();
            this.Faktura = new HashSet<Faktura>();
            this.Najem = new HashSet<Najem>();
        }

        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Ulica { get; set; }
        public int NrDomu { get; set; }
        public string Miasto { get; set; }
        public string NIP { get; set; }
        public int PlatnoscID { get; set; }

        public ICollection<Sprzedawca_Klient> Sprzedawca_Klient { get; set; }
        public ICollection<Produkt_Klient> Produkt_Klient { get; set; }
        public ICollection<Konto> Konto { get; set; }
        public ICollection<Faktura> Faktura { get; set; }
        public ICollection<Najem> Najem { get; set; }

        public virtual Platnosc Platnosc { get; set; }
    }
}