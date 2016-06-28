using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Produkt
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public decimal CenaNettoZaSzt { get; set; }
        public int Ilosc { get; set; }
        public int VAT
        {
            get
            {
                return 23;
            }
        }
        public decimal CenaNettoCalosc
        {
            get
            {
                return CenaNettoZaSzt * Ilosc;
            }
        }
        public decimal CenaBruttoCalosc
        {
            get
            {
                return CenaNettoCalosc + CenaNettoCalosc * ((decimal)VAT / 100);
            }
        }

        public ICollection<Produkt_Klient> Produkt_Klient { get; set; }
    }
}