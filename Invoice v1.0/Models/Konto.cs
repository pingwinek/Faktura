using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Konto
    {
        public int ID { get; set; }
        public long NrKonta { get; set; }
        public string Bank { get; set; }
        public int KlientID { get; set; }

        public virtual Klient Klient { get; set; }
    }
}