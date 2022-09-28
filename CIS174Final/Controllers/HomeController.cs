using CIS174Final.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIS174Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        //Custom routing
        //In this case the Controller is Home and the Action is CustomRoute page.
        //Access via localhost/Custom/Home/CustomRoute
        [Route("Custom/[controller]/[action]")]
        public IActionResult CustomRoute()
        {
            return View();
        }
        //Attribute routing
        //Access via localhost/Attribute
        [Route("Attribute")]
        public IActionResult AttributeRoute()
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