using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace BandApp.Controllers
{
    public class BandLidController : Controller
    {
        private static List<Band> bands;

        public BandLidController()
        {
            bands = BandCreator.StartUp();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lijst()
        {
            ViewBag.Bands= bands;
            return View();
        }

        public ViewResult Maak(string naam, int? jaar, Geslacht? geslacht, string band)
        {
            bands.Add(
                new Band()
                {
                    Naam = band ?? "Onbekend",
                    Leden = new List<BandLid>()
                    {
                        new BandLid()
                        {
                            Naam = naam ?? "Onbekend",
                            Geslacht = geslacht ?? Geslacht.Man
                        }
                    }
                });
            ViewBag.Bands = bands;

            return View("Lijst");
        }
    }
}