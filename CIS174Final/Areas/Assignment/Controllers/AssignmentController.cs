using Microsoft.AspNetCore.Mvc;

namespace CIS174Final.Areas.Assignment.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult ControllerIndex()
        {
            return View();
        }

        public IActionResult StudentView()
        {
            /* TODO */
            return View();
        }
    }
}
