using Microsoft.AspNetCore.Mvc;

namespace MyCineTime.Controllers;

public class ActorsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}