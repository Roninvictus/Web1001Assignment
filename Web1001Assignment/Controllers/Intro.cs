using Microsoft.AspNetCore.Mvc;

namespace Web1001Assignment.Controllers;

public class Intro : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}