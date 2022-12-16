using InertiaAdapter;
using Microsoft.AspNetCore.Mvc;

namespace InertiaDemo.Backend.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Inertia.Render("Home", new { title = "Home" });
    }
    
    [HttpGet("about")]
    public IActionResult About()
    {
        return Inertia.Render("About", new { title = "About" });
    }
}