using Invoice_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invoice_v1._0.Controllers
{
    public class HomeController : Controller
    {
        private DaneDoFakturyContext dane = new DaneDoFakturyContext();

        public ActionResult Index()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.allFaktures = dane.Faktura.Where(f => f.ID == 1).ToList();
            viewModel.allKlients = dane.Klient.Where(f => f.ID == 1).ToList();
            viewModel.allKonto = dane.Konto.Where(f => f.ID == 1).ToList();
            viewModel.allPlatnosc = dane.Platnosc.Where(f => f.ID == 1).ToList();
            viewModel.allNajem = dane.Najem.Where(f => f.ID == 1).ToList();
            viewModel.allSprzedawca = dane.Sprzedawca.Where(f => f.ID == 1).ToList();
            viewModel.allProducts = dane.Produkt.ToList();

            return View(viewModel);
        }

        // GET: Ogloszenie/Create
        public ActionResult Create()
        {
            //ViewBag.UzytkownikId = new SelectList(dane.Klient, "ID", "Imie", "Nazwisko");
            return View();
        }

        // POST: Ogloszenie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nazwa,CenaNettoZaSzt,Ilosc")] Produkt produkt)
        {
            if (ModelState.IsValid)
            {
                dane.Produkt.Add(produkt);
                dane.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.UzytkownikId = new SelectList(dane.Klient, "ID", "Imie", "Nazwisko", produkt.Ilosc);
            return View(produkt);
        }
    }
}