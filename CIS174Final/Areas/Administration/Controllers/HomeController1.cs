using Microsoft.AspNetCore.Mvc;

namespace CIS174Final.Areas.Administration.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
