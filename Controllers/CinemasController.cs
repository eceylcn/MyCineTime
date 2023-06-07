using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCineTime.Data;

namespace MyCineTime.Controllers;

public class CinemasController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public CinemasController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IActionResult> Index()
    {
        var allCinemas = await _context.Cinemas.ToListAsync();
        return View(allCinemas);
    }

    public IActionResult Edit()
    {
        throw new NotImplementedException();
    }

    public IActionResult Details()
    {
        throw new NotImplementedException();
    }

    public IActionResult Delete()
    {
        throw new NotImplementedException();
    }
}