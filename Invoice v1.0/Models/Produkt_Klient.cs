using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Produkt_Klient
    {
        public int ID { get; set; }
        public int ProduktID { get; set; }
        public int KlientID { get; set; }

        public virtual Produkt Produkt { get; set; }
        public virtual Klient Klient { get; set; }
    }
}