using Microsoft.AspNetCore.Mvc;

namespace MyCineTime.Controllers;

public class MoviesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}