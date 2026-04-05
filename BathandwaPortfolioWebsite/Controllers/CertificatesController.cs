using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using BathandwaPortfolioWebsite.Models;


namespace BathandwaPortfolioWebsite.Controllers;

public class CertificatesController : Controller
{
    private readonly IWebHostEnvironment _env;

    public CertificatesController(IWebHostEnvironment env)
    {
        _env = env;
    }

    public IActionResult Index()
    {
        var path = Path.Combine(_env.ContentRootPath, "Data", "certificates.json");
        var json = System.IO.File.ReadAllText(path);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var all = JsonSerializer.Deserialize<List<Certificate>>(json, options) ?? [];

        
        var grouped = all
            .Where(c => c.Group != null)
            .GroupBy(c => c.Group!)
            .ToDictionary(g => g.Key, g => g.ToList());
        
        
        var standalone = all.Where(c => c.Group == null).ToList();

        ViewBag.Grouped = grouped;
        ViewBag.Standalone = standalone;

        return View();
    }
}