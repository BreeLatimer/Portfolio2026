using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers;

public class GameController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
