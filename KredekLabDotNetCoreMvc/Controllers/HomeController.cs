using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KredekLabDotNetCoreMvc.Models;
using System.IO;

namespace KredekLabDotNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista samochodów do wyświetlenia
        /// </summary>
        List<CarViewModel> allCars;

        /// <summary>
        /// Konstruktor z parametrem
        /// </summary>
        /// <param name="context"></param>
        public HomeController()
        {
            this.allCars = new List<CarViewModel>();
            allCars.Add(new CarViewModel("Focus", "Ford", 72000, "~/focus.png"));
            allCars.Add(new CarViewModel("Golf", "Volkswagen", 80000, "~/golf.png"));
            allCars.Add(new CarViewModel("Civic", "Honda", 82000, "~/civic.png"));
            allCars.Add(new CarViewModel("Megane", "Renault", 67000, "~/megane.png"));    
        }

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Widok z ciekawymi linkami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult InterestingLinks()
        {
            return View();
        }

        /// <summary>
        /// Lista wszystkich samochodów z bazy danych
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllCars()
        {
            return View(this.allCars);
        }

        /// <summary>
        /// Wyświetlenie listy modeli samochodów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetListOfModels()
        {
            // Lista nazw modeli samochodów do wyświetlenia
            List<string> allModels = new List<string>();

            // Pętla dodająca model samochodu do listy
            foreach(CarViewModel car in this.allCars)
            {
                allModels.Add(car.Model);
            }
            // Przekazanie listy modeli do widoku
            return View(allModels);
        }

        /// <summary>
        /// Pobranie samochodu po jego modelu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCarByModel(string model)
        {
            // Wyszukanie samochodu po modelu
            CarViewModel car = this.allCars.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
            // Przekazanie obiektu do widoku
            return View(car);
        }
        
        /// <summary>
        /// Wyświetlenie formularza kontaktowego do wypełnienia
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie powitania po wypełnieniu formularza kontaktowego
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }

        /// <summary>
        /// Wyświetlenie informacji o błędzie
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
