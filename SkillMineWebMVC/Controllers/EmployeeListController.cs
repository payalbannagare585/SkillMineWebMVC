using Microsoft.AspNetCore.Mvc;
using SkillMineWebMVC.Models;

namespace SkillMineWebMVC.Controllers
{
    public class EmployeeListController : Controller
    {
        public IActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>()
            {
              new Employee{empId=201,empName="Payal Bannagare",empSalary=35000},
              new Employee{empId = 202,empName="Vaishnavi Ingle",empSalary=30000},
              new Employee{empId = 203,empName="Kalyani Pachghare",empSalary=24000},
              new Employee{empId = 204,empName="Rolly Kawale",empSalary=30000},
            };
            ViewData["emplist"] = employees;
            return View();
            
        }
    }
}
