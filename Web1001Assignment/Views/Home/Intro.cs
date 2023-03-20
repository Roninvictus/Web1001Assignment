using Microsoft.AspNetCore.Mvc;

namespace Web1001Assignment.Views.Home;

public class Intro : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}