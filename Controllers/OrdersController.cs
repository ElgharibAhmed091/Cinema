using Cinema.Data;
using Cinema.Models;
using Cinema.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Checkout()
        {
            var user = await _userManager.GetUserAsync(User);
            var cartItems = _context.CartItems.Include(c => c.Movie)
                                              .Where(c => c.UserId == user.Id)
                                              .ToList();

            var total = cartItems.Sum(i => i.Movie.Price * i.Quantity);

            var paymentService = new StripePaymentService();
            var url = paymentService.CreateCheckoutSession(total);

            return Redirect(url);
        }

        public IActionResult Success()
        {
            if (_context == null)
                return StatusCode(500, "Database context is null.");

            // جلب العناصر مع التأكد من عدم وجود null
            var cartItems = _context.CartItems
                                    .Include(c => c.Movie)
                                    .Where(c => c.Movie != null) // نتأكد أن كل CartItem مرتبط بـ Movie
                                    .ToList();

            if (cartItems == null || !cartItems.Any())
            {
                ViewBag.Message = "Your cart is empty.";
                return View(new List<CartItem>());
            }

            return View(cartItems);
        }

        public IActionResult Cancel()
        {
            return View(); // Cancel.cshtml
        }
    }
}
