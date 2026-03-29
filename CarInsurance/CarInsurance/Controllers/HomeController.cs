using System.Diagnostics;
using CarInsurance.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        // Home controller handles requests for the home section of the site.
        // In MVC, controllers decide what to do when a user visits a URL.

        private readonly ILogger<HomeController> _logger;

        //controllers constructor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //root url returns the index.cshtml view
        public IActionResult Index()
        {
            return View();
        }
        
        //returns the privacy cshtml view
        public IActionResult Privacy()
        {
            return View();
        }

        //error handling 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
