using Microsoft.AspNetCore.Mvc;
using SkillMineWebMVC.Models;

namespace SkillMineWebMVC.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
              new Product{Id=101,Name="mouse",Price=999},
              new Product{Id=102,Name="Laptop",Price=5926},
              new Product{Id=103,Name="charger",Price=455},
              new Product{Id=104,Name="Monitor",Price=3000},
            };
            ViewData["prodlist"]=products;
            ViewBag.Products = products;
            return View();
        }
    }
}
