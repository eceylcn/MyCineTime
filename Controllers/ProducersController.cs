using Microsoft.AspNetCore.Mvc;

namespace MyCineTime.Controllers;

public class Producers : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}