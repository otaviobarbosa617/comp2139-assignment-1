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
    }

}


