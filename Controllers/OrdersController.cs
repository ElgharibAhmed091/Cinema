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

        public async Task<IActionResult> Success()
        {
            var user = await _userManager.GetUserAsync(User);
            var cartItems = _context.CartItems.Include(c => c.Movie)
                                              .Where(c => c.UserId == user.Id).ToList();

            var order = new Order
            {
                UserId = user.Id,
                OrderDate = DateTime.Now,
                TotalAmount = (decimal)cartItems.Sum(i => i.Movie.Price * i.Quantity),
                OrderItems = cartItems.Select(i => new OrderItem
                {
                    MovieId = i.MovieId,
                    Quantity = i.Quantity,
                    Price = (decimal)i.Movie.Price
                }).ToList()
            };

            _context.Orders.Add(order);
            _context.CartItems.RemoveRange(cartItems);
            await _context.SaveChangesAsync();

            return View(); // Success.cshtml
        }

        public IActionResult Cancel()
        {
            return View(); // Cancel.cshtml
        }
    }
}
