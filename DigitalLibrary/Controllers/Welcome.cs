using Microsoft.AspNetCore.Mvc;

namespace DigitalLibrary.Controllers
{
    public class Welcome : Controller
    {
        // GET
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to our Digital Library";
            return View();
        }

        public string Description()
        {
            return "This is the application for managing digital library";
        }
    }
}