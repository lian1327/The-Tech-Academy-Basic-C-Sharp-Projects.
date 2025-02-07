using Microsoft.AspNetCore.Mvc;
using Assign23MVCProj.Models;
using Assign23MVCProj.Data;

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
        public IActionResult Create()
        {
            return View();
        }

        public decimal CalculateQuote(Insuree insuree)
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

        // Add methods for Create and Admin views
    }
}
