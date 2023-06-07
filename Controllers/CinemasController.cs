using Microsoft.AspNetCore.Mvc;

namespace MyCineTime.Controllers;

public class CinemasController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}