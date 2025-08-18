using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Data;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class Actor_MovieController : Controller
    {
        private readonly AppDbContext _context;

        public Actor_MovieController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Actor_Movie
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Actor_Movies.Include(a => a.Actor).Include(a => a.Movie);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Actor_Movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor_Movie = await _context.Actor_Movies
                .Include(a => a.Actor)
                .Include(a => a.Movie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actor_Movie == null)
            {
                return NotFound();
            }

            return View(actor_Movie);
        }

        // GET: Actor_Movie/Create
        public IActionResult Create()
        {
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Bio");
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id");
            return View();
        }

        // POST: Actor_Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MovieId,ActorId")] Actor_Movie actor_Movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actor_Movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Bio", actor_Movie.ActorId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", actor_Movie.MovieId);
            return View(actor_Movie);
        }

        // GET: Actor_Movie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor_Movie = await _context.Actor_Movies.FindAsync(id);
            if (actor_Movie == null)
            {
                return NotFound();
            }
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Bio", actor_Movie.ActorId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", actor_Movie.MovieId);
            return View(actor_Movie);
        }

        // POST: Actor_Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MovieId,ActorId")] Actor_Movie actor_Movie)
        {
            if (id != actor_Movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actor_Movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Actor_MovieExists(actor_Movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActorId"] = new SelectList(_context.Actors, "Id", "Bio", actor_Movie.ActorId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", actor_Movie.MovieId);
            return View(actor_Movie);
        }

        // GET: Actor_Movie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor_Movie = await _context.Actor_Movies
                .Include(a => a.Actor)
                .Include(a => a.Movie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actor_Movie == null)
            {
                return NotFound();
            }

            return View(actor_Movie);
        }

        // POST: Actor_Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor_Movie = await _context.Actor_Movies.FindAsync(id);
            if (actor_Movie != null)
            {
                _context.Actor_Movies.Remove(actor_Movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Actor_MovieExists(int id)
        {
            return _context.Actor_Movies.Any(e => e.Id == id);
        }
    }
}
