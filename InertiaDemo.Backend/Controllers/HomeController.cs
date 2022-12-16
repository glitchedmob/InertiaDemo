using System.Diagnostics;
using InertiaAdapter;
using Microsoft.AspNetCore.Mvc;
using InertiaDemo.Backend.Models;
using Microsoft.AspNetCore.Components.RenderTree;

namespace InertiaDemo.Backend.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return Inertia.Render("Home", new { title = "Home" });
    }
}