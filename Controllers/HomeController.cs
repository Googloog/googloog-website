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

    public HomeController(Sooziales_NetzwerkDbContext context, ILogger<HomeController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Link.ToListAsync());
    }

    public async Task<IActionResult> LikeButton(){
        /*Console.WriteLine("Test!");
        link.likes = link.likes + 1;
        _context.Update(link);
        _context.SaveChanges();
        Console.WriteLine("Test2");*/
        return View(await _context.Link.ToListAsync());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Profile()
    {
        return View(await _context.Link.ToListAsync());
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
