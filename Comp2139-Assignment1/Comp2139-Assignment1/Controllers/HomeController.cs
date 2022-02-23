using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Comp2139_Assignment1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Technicians()
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
    }

}


