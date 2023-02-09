using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SkillMineWebMVC.Controllers
{
    public class EmployeeInfoController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetail()
        {
            List<string> department = new List<string> { "Select Department", "HR", "Marketing", "Devleopment", "Sales" };
            ViewData["department"] = new SelectList(department);
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeDetail(IFormCollection form)
        {
            ViewBag.EmpId = form["empid"];
            ViewBag.EmpName = form["empname"];
            ViewBag.EmpSalary = form["empsalary"];
            ViewBag.Department = form["department"];
            
            return View("EmpDetail");
        }
    }
}
