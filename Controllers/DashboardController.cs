// DashboardController.cs
using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize(Roles = "Admin")]
public class DashboardController : Controller
{
    private readonly AppDbContext _ctx;
    private readonly UserManager<ApplicationUser> _userManager;

    public DashboardController(AppDbContext ctx, UserManager<ApplicationUser> userManager)
    {
        _ctx = ctx;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users.ToListAsync();
        var userList = new List<UserWithRole>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            var role = roles.FirstOrDefault() ?? "User";
            userList.Add(new UserWithRole
            {
                Id = user.Id,
                Email = user.Email,
                Role = role
            });
        }

        var vm = new DashboardViewModel
        {
            CarCount = await _ctx.Movies.CountAsync(),
            UserCount = await _ctx.Users.CountAsync(),
            OrderCount = await _ctx.Orders.CountAsync(),
            TotalRevenue = await _ctx.Orders.SumAsync(o => o.TotalAmount),
            LatestOrders = await _ctx.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Movie)
                .OrderByDescending(o => o.OrderDate)
                .Take(5)
                .ToListAsync(),
            UsersWithRoles = userList
        };

        return View(vm);
    }
}

// ViewModels
public class DashboardViewModel
{
    public int CarCount { get; set; }
    public int UserCount { get; set; }
    public int OrderCount { get; set; }
    public decimal TotalRevenue { get; set; }
    public List<Order> LatestOrders { get; set; } = new();
    public List<UserWithRole> UsersWithRoles { get; set; } = new();
}

public class UserWithRole
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}
