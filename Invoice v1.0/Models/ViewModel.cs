using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class ViewModel
    {
        public List<Produkt> allProducts { get; set; }
        public List<Faktura> allFaktures { get; set; }
        public List<Klient> allKlients { get; set; }
        public List<Konto> allKonto { get; set; }
        public List<Najem> allNajem { get; set; }
        public List<Platnosc> allPlatnosc { get; set; }
        public List<Sprzedawca> allSprzedawca { get; set; }
    }
}