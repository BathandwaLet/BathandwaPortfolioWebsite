using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BathandwaPortfolioWebsite.Models;

namespace BathandwaPortfolioWebsite.Controllers;

public class AboutController : Controller
{
    public IActionResult Index() => View();
}
