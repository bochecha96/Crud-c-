using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoLocadora.Models;

namespace ProjetoLocadora.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
