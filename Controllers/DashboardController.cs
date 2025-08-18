using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        var users = _userManager.Users.ToList();
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
            MovieCount = await _ctx.Movies.CountAsync(),
            UserCount = await _ctx.Users.CountAsync(),
            OrderCount = await _ctx.Orders.CountAsync(),
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

    [HttpPost]
    public async Task<IActionResult> MakeAdmin(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            var roles = await _userManager.GetRolesAsync(user);
            if (!roles.Contains("Admin"))
                await _userManager.AddToRoleAsync(user, "Admin");
        }

        return RedirectToAction("Index");
    }
}

public class DashboardViewModel
{
    public int MovieCount { get; set; }
    public int UserCount { get; set; }
    public int OrderCount { get; set; }
    public List<Order> LatestOrders { get; set; } = new();
    public List<UserWithRole> UsersWithRoles { get; set; } = new();
}

public class UserWithRole
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}
