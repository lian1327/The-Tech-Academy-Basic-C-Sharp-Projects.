using Microsoft.AspNetCore.Mvc;

namespace FinalAssignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
