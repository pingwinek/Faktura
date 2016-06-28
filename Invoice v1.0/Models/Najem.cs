using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class Najem
    {
        public int ID { get; set; }
        public string NrNajmu { get; set; }
        public int KlientID { get; set; }

        public virtual Klient Klient { get; set; }
    }
}