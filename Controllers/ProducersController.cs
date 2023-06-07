using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCineTime.Data;

namespace MyCineTime.Controllers;

public class ProducersController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public ProducersController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    // GET
    public async Task<IActionResult> Index()
    {
        var allProducers = await _context.Producers.ToListAsync();
        return View(allProducers);
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