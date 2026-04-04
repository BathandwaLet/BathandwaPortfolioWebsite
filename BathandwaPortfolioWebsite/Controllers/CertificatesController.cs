using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BathandwaPortfolioWebsite.Models;


namespace BathandwaPortfolioWebsite.Controllers;

public class CertificatesController : Controller
{
    public IActionResult Index() => View();
}