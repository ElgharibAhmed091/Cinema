using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;

[Authorize]
public class PaymentController : Controller
{
    private readonly IConfiguration _configuration;
    private readonly AppDbContext _context;

    public PaymentController(IConfiguration configuration, AppDbContext context)
    {
        _configuration = configuration;
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCheckoutSession()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return RedirectToAction("Login", "Account");

        var cartItems = await _context.CartItems
            .Include(c => c.Movie)
            .ThenInclude(m => m.Cinema) // ناخد الـ Cinema مع كل Movie
            .Where(c => c.UserId == userId)
            .ToListAsync();

        if (!cartItems.Any()) return RedirectToAction("Index", "Cart");

        // إعداد الـ Stripe line items
        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card" },
            LineItems = cartItems.Select(item => new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmount = (long)(item.Movie.Price * 100),
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = item.Movie.Name,
                        Description = item.Movie.Description,
                    },
                },
                Quantity = item.Quantity,
            }).ToList(),
            Mode = "payment",
            SuccessUrl = Url.Action("Success", "Payment", null, Request.Scheme),
            CancelUrl = Url.Action("Cancel", "Payment", null, Request.Scheme),
        };

        var service = new SessionService();
        Session session = service.Create(options);

        return Redirect(session.Url);
    }

    public async Task<IActionResult> Success()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) return RedirectToAction("Login", "Account");

        // جلب CartItems بعد الدفع
        var cartItems = await _context.CartItems
            .Include(c => c.Movie)
            .ThenInclude(m => m.Cinema)
            .Where(c => c.UserId == userId)
            .ToListAsync();

        if (!cartItems.Any()) return RedirectToAction("Index", "Cart");

        // إنشاء OrderItems
        var orderItems = cartItems.Select(c => new OrderItem
        {
            MovieId = c.MovieId,
            CinemaId = c.Movie.CinemaId, // هنا مهم جدًا
            Quantity = c.Quantity
        }).ToList();

        // إنشاء Order
        var order = new Order
        {
            UserId = userId,
            OrderDate = DateTime.Now,
            TotalAmount = (decimal)cartItems.Sum(c => c.Movie.Price * c.Quantity),
            OrderItems = orderItems
        };

        _context.Orders.Add(order);

        // حذف عناصر السلة بعد الدفع
        _context.CartItems.RemoveRange(cartItems);

        await _context.SaveChangesAsync();

        return View();
    }

    public IActionResult Cancel()
    {
        return View();
    }
}
