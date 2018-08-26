using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace BandApp.Controllers
{
    public class BandController : Controller
    {
        private List<Band> bands;

        public BandController()
        {
            bands = BandCreator.StartUp();
        }

        public ViewResult Index()
        {
            
            return View();
        }

        public ViewResult Lijst()
        {
            ViewBag.bands = bands;
            return View();
        }

        public ViewResult LijstMetLeden()
        {
            ViewBag.Bands = bands;
            return View();
        }

        public ViewResult Maak(string naam, int? jaar)
        {
            bands.Add(new Band()
            {
                Naam = naam ?? "Onbekend",
                Jaar = jaar ?? DateTime.Now.Year
            });
            ViewBag.bands = bands;

            return View("Lijst");
        }

        public IActionResult JSLijst()
        {
            return Json(bands);
        }
    }
}