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

        [Display(Name="Imię")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Display(Name = "Płeć")]
        public string Gender { get; set; }

        [Display(Name = "Miasto")]
        [MaxLength(30)]
        public string City { get; set; }

        [Display(Name = "Ulica")]
        [MaxLength(30)]
        public string Street { get; set; }

        [Display(Name = "Numer domu")]
        public int NumberOfAddress { get; set; }

        [Display(Name = "Nazwa produktu")]
        [MaxLength(30)]
        public string Product { get; set; }

        [Display(Name = "Cena za 1 szt.")]
        public decimal PriceForOne { get; set; }

        [Display(Name = "Ilość")]
        public int Amounts { get; set; }

        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Display(Name = "Suma")]
        public decimal TotalPrice
        {
            get
            {
                return PriceForOne * Amounts;
            }
        }
    }
}