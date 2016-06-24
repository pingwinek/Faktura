using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invoice_v1._0.Models
{
    public class DaneDoFaktury
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberOfAddress { get; set; }
        public string Product { get; set; }
        public decimal PriceForOne { get; set; }
        public int Amounts { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return PriceForOne * Amounts;
            }
        }
    }
}