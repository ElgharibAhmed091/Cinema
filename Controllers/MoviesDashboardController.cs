using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    public class MoviesDashboardController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesDashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var totalMovies = _context.Movies.Count();
      
            var movies = _context.Movies.ToList();

            ViewBag.TotalMovies = totalMovies;
         

            return View(movies);
        }
    }
}
