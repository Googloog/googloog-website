using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sooziales_Netzwerk.Models;
using Microsoft.EntityFrameworkCore;
using Sooziales_Netzwerk.Data;

namespace Sooziales_Netzwerk.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Sooziales_NetzwerkDbContext _context;

    /*public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }*/

    public HomeController(Sooziales_NetzwerkDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Link.ToListAsync());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult TermsOfService()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
