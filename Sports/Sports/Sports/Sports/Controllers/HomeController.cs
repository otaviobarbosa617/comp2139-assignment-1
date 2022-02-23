using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sports.Models;

namespace Sports.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

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
}
