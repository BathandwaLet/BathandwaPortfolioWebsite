using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using BathandwaPortfolioWebsite.Models;


namespace BathandwaPortfolioWebsite.Controllers;

public class ProjectsController : Controller
{
    private readonly IWebHostEnvironment _env;
    public ProjectsController(IWebHostEnvironment env)
    {
        _env = env;
    }
    public IActionResult Index()
    {
        var path = Path.Combine(_env.ContentRootPath, "Data", "projects.json");
        var json = System.IO.File.ReadAllText(path);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var all = JsonSerializer.Deserialize<List<Project>>(json, options) ?? [];

        var featured = all.Where(p => p.Featured == true).ToList();

        ViewBag.featured = featured;
        
        return View();  
    }

    public IActionResult Detail(string slug)
    {
        var path = Path.Combine(_env.ContentRootPath, "Data", "projects.json");
        var json = System.IO.File.ReadAllText(path);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var all = JsonSerializer.Deserialize<List<Project>>(json, options) ?? [];

        var featured = all.Where(p => p.Featured == true).ToList();
        
        ViewBag.featured = featured;
        //find a way to isolate a single project.
        
        return View();
    }
}