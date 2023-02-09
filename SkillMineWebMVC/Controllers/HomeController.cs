using Microsoft.AspNetCore.Mvc;
using SkillMineWebMVC.Models;
using System.Diagnostics;

namespace SkillMineWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            TempData["message"] = "Welcome to mvc core";
            TempData.Keep("message");

            List<string> colors = new List<string>() {"red","Green","Blue","White","Black"};
            ViewData["Colors"]=colors;

            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}