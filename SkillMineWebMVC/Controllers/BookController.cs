using Microsoft.AspNetCore.Mvc;
using SkillMineWebMVC.Models;
namespace SkillMineWebMVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Book book)
        {
            ViewBag.Name=book.Name;
            ViewBag.Author=book.Author;
            ViewBag.Price=book.Price;

            return View("Show");
        }
    }
}
