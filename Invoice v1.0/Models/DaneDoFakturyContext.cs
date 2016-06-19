using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class DaneDoFakturyContext : DbContext
    {
        public DbSet<DaneDoFaktury> DaneDoFaktury { get; set; }
    }
}