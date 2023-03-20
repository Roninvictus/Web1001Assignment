using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web1001Assignment.Models;

namespace Web1001Assignment.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(int num1, int num2)
    {
        int result = num1 + num2;

        return View(result);
    }
}