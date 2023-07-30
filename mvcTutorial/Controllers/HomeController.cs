using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcTutorial.Models;

namespace mvcTutorial.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(Person.GetPerson());
    }

    public IActionResult Privacy()
    {
        return View(Person.GetPerson());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
