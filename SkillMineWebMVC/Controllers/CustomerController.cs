using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SkillMineWebMVC.Controllers
{
    public class CustomerController : Controller
    {
       
            [HttpGet]
            public IActionResult CustomerOrder()
            {
                List<string> snacks = new List<string> { "Select Snacks", "Cheese Crackers", "Tortilla Chips", "Popcorn", "Mixed Fruit", "Cottage cheese", "Trail mix" };
                ViewData["snacks"] = new SelectList(snacks);
                return View();

            }
            [HttpPost]
            public IActionResult CustomerOrder(IFormCollection form)
            {
                ViewBag.Name = form["pname"];
                ViewBag.Mobile = form["mobile"];
                ViewBag.Payment = form["Payment"];
                ViewBag.Snacks = form["snacks"];
                
                return View("CustOrder");


            }

           
        
    }
}
