using Cinema.Models;
using Cinema.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Cinema.Controllers
{
    [Authorize] // يتأكد إن المستخدم مسجل دخول
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        { 
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            var cartItems = await _context.CartItems
                .Include(c => c.Movie)
                .Where(c => c.UserId == user.Id)
                .ToListAsync();

            return View(cartItems);
        }

        public async Task<IActionResult> Add(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            var existing = await _context.CartItems
                .FirstOrDefaultAsync(x => x.MovieId == id && x.UserId == user.Id);

            if (existing != null)
            {
                existing.Quantity += 1;
            }
            else
            {
                var movie = await _context.Movies.FindAsync(id);
                if (movie == null) return NotFound();

                _context.CartItems.Add(new CartItem
                {
                    MovieId = movie.Id,
                    Quantity = 1,
                    UserId = user.Id,
                    Name = movie.Name, // مهم
                    Price = movie.Price
                });

            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Remove(int id)
        {
            var item = await _context.CartItems.FindAsync(id);
            if (item == null) return NotFound();

            _context.CartItems.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity, string change)
        {
            var item = await _context.CartItems.FindAsync(cartItemId);
            if (item == null) return NotFound();

            if (change == "increase") item.Quantity += 1;
            else if (change == "decrease" && item.Quantity > 1) item.Quantity -= 1;
            else item.Quantity = quantity; // لو المستخدم عدل الرقم مباشرة

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
