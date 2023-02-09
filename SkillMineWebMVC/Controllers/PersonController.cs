using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SkillMineWebMVC.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public  IActionResult PersonalDetails()
        {
            List<string> cities = new List<string> { "Select City", "Pune", "Mumbai", "Nagpur", "Nashik", "Sangli", "Akola" };
            ViewData["cities"] = new SelectList(cities);
            return View();

        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form,ICollection<string> hobbies)
        {
            ViewBag.Name = form["pname"];
            ViewBag.Mobile = form["mobile"];
            ViewBag.Gender = form["Gender"];
            ViewBag.City = form["cities"];
            ViewBag.Hobbies = hobbies;
            return View("Details");

            
        }
    }
}
