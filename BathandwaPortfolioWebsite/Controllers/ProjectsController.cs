using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BathandwaPortfolioWebsite.Models;


namespace BathandwaPortfolioWebsite.Controllers;

public class ProjectsController : Controller
{
    public IActionResult Index() => View();
    
    public IActionResult Detail(string slug) => View();
}