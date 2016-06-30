using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Produkt
    {
        public int ID { get; set; }

        [MaxLength(12)]
        [Required]
        public string Nazwa { get; set; }

        [Range(0.99,100)]
        [Required]
        [Display(Name="Cena netto za jedną sztukę")]
        public decimal CenaNettoZaSzt { get; set; }

        [Range(1,100)]
        [Required]
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
                return CenaNettoCalosc + (CenaNettoCalosc * ((decimal)VAT / 100));
            }
        }

        public ICollection<Produkt_Klient> Produkt_Klient { get; set; }
    }
}