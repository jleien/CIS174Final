using Microsoft.AspNetCore.Mvc;

namespace CIS174Final.Areas.Assignment.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
