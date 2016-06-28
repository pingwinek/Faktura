using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Sprzedawca
    {
        public Sprzedawca()
        {
            this.Sprzedawca_Klient = new HashSet<Sprzedawca_Klient>();
        }

        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Ulica { get; set; }
        public int NrDomu { get; set; }
        public string Miasto { get; set; }
        public string NIP { get; set; }

        public ICollection<Sprzedawca_Klient> Sprzedawca_Klient { get; set; }
    }
}