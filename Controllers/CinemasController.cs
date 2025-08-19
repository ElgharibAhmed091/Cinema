using Cinema.Data;
using Cinema.Dto;
using Cinema.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cinemas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cinemas.ToListAsync());
        }

        // GET: Cinemas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinemas = await _context.Cinemas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cinemas == null)
            {
                return NotFound();
            }

            return View(cinemas);
        }
        [Authorize(Roles = "Admin")]
        // GET: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cinemas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CinemasVM vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var cinema = new Cinemas
            {
                Logo = vm.Logo,
                Name = vm.Name,
                Description = vm.Description
            };

            _context.Cinemas.Add(cinema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Cinemas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinemas = await _context.Cinemas.FindAsync(id);
            if (cinemas == null)
            {
                return NotFound();
            }
            return View(cinemas);
        }

        // POST: Cinemas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinemas cinemas)
        {
            if (id != cinemas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cinemas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CinemasExists(cinemas.Id))
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
            return View(cinemas);
        }

        // GET: Cinemas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinemas = await _context.Cinemas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cinemas == null)
            {
                return NotFound();
            }

            return View(cinemas);
        }

        // POST: Cinemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemas = await _context.Cinemas.FindAsync(id);
            if (cinemas != null)
            {
                _context.Cinemas.Remove(cinemas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CinemasExists(int id)
        {
            return _context.Cinemas.Any(e => e.Id == id);
        }
    }
}
