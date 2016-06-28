using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Platnosc
    {
        public int ID { get; set; }
        public string SposobPlatnosci { get; set; }

        public ICollection<Klient> Klient { get; set; }
    }
}