using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCineTime.Data;

namespace MyCineTime.Controllers;

public class MoviesController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public MoviesController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IActionResult> Index()
    {
        // filmlerin azalan şekilde sıralanmasını istiyorum
        var allMovies = await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
        return View(allMovies);
    }

    public IActionResult Edit()
    {
        throw new NotImplementedException();
    }

    public IActionResult Filter()
    {
        throw new NotImplementedException();
    }
    
    [HttpGet]
    [HttpGet]
public IActionResult Search(string searchString)
{
    var movieNames = _context.Movies
        .Where(m => m.Name.Contains(searchString))
        .Select(m => m.Name)
        .ToList();
    
    return Json(movieNames);
}


    
}