using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCineTime.Data;
using MyCineTime.Models;

namespace MyCineTime.Controllers;

public class ActorsController : Controller
{
    private readonly ApplicationDbContext _context;
    
    //contexti kullanabilmek icin constructor getiriyorum
    public ActorsController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    // GET
    public async Task<IActionResult> Index()
    {
        return View(await _context.Actors.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
    {
        if (ModelState.IsValid)
        {
            return View(actor);
        }
        _context.Actors.Add(actor);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
    [HttpGet]
    [ActionName("Details")]
    public async Task<IActionResult> Details(int id)
    {
        var actor = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);

        if (actor == null)
        {
            return NotFound();
        }
        return View(actor);
    }
    
    public async Task<IActionResult> Edit(int id)
    {
        var actor = await _context.Actors.FindAsync(id);

        if (actor == null)
        {
            return NotFound();
        }

        return View(actor);
    }
    
    [HttpPost]
    [ActionName("Edit")]
    public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
    {
        if (id != actor.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            return View(actor);
        }

        _context.Update(actor);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

// delete yaparken
    public async Task<IActionResult> Delete(int id)
    {
        var actor = await _context.Actors.FindAsync(id);

        if (actor == null)
        {
            return NotFound();
        }

        return View(actor);
    }

    [HttpPost]
    [ActionName("DeleteConfirmed")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var actor = await _context.Actors.FindAsync(id);

        if (actor == null)
        {
            return NotFound();
        }

        _context.Actors.Remove(actor);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}