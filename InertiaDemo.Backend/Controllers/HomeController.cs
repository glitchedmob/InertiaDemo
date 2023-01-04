using InertiaAdapter;
using InertiaDemo.Backend.Data;
using InertiaDemo.Backend.Dto;
using InertiaDemo.Backend.Models;
using InertiaDemo.Backend.Requests;
using Microsoft.AspNetCore.Mvc;

namespace InertiaDemo.Backend.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return Inertia.Render("Home", new HomeDto { Title = "Home"});
    }
    
    [HttpGet("about")]
    public IActionResult About()
    {
        return Inertia.Render("About", new { title = "About" });
    }

    
    [HttpGet("contact")]
    public IActionResult Contact()
    {
        return Inertia.Render("Contact", new { });
    }

     [HttpPost("contact")]
     public async Task<IActionResult> SaveContact([FromBody] SaveContactRequest contactRequest)
     {
         var contact = new Contact
         {
             Name = contactRequest.Name,
             Message = contactRequest.Message
         };

         await _context.Contacts.AddAsync(contact);
         await _context.SaveChangesAsync();

         return Redirect("/");
     }
}