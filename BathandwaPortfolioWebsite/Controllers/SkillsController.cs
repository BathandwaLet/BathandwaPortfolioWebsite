using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BathandwaPortfolioWebsite.Models;


namespace BathandwaPortfolioWebsite.Controllers;

public class SkillsController : Controller
{
    public IActionResult Index() => View();
}