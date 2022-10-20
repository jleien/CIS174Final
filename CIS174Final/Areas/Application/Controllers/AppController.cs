
using CIS174Final.Controllers;
using CIS174Final.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
//this is what is being shown when you go to character creator and i dont know why
namespace CIS174Final.Areas.Application.Controllers
{
    [Area("Application")]
    public class AppController : Controller
    {
        private readonly ILogger<AppController> _logger;

        public AppController(ILogger<AppController> logger)
        {
            _logger = logger;
        }

        public IActionResult CharacterCreator(int character)
        {
            return View();

        }

        public IActionResult PartyViewer()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
