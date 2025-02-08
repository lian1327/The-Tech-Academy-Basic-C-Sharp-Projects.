using Microsoft.AspNetCore.Mvc;
using Assign23MVCProj.Models;
using Assign23MVCProj.Data;
using System.Linq;

namespace Assign23MVCProj.Controllers
{
    public class InsureeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InsureeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Admin()
        {
            var insurees = _context.Insurees.ToList();
            return View(insurees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Insuree insuree)
        {
            insuree.Quote = CalculateQuote(insuree);
            _context.Insurees.Add(insuree);
            _context.SaveChanges();
            return RedirectToAction("Admin");
        }

        private decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50;

            // Age adjustment
            if (insuree.Age <= 18)
            {
                quote += 100;
            }
            else if (insuree.Age >= 19 && insuree.Age <= 25)
            {
                quote += 50;
            }
            else if (insuree.Age >= 26)
            {
                quote += 25;
            }

            // Car year adjustment
            if (insuree.CarYear < 2000)
            {
                quote += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                quote += 25;
            }

            // Car make and model adjustment
            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25;
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25;
                }
            }

            // Speeding ticket adjustment
            quote += insuree.SpeedingTickets * 10;

            // DUI adjustment
            if (insuree.HasDUI)
            {
                quote *= 1.25m;
            }

            // Full coverage adjustment
            if (insuree.IsFullCoverage)
            {
                quote *= 1.50m;
            }

            return quote;
        }
    }
}
