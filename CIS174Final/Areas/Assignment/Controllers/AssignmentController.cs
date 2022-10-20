using CIS174Final.Areas.Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174Final.Areas.Assignment.Controllers
{
    [Area("AssignmentModule7")]
    public class AssignmentController : Controller
    {
        private StudentContext context { get; set; }
        public AssignmentController(StudentContext ctx)
        {
            context = ctx;
        }
        
        public IActionResult Index()
        {
            var students = context.TestStudents.ToList();
            return View(students);
        }

        public IActionResult StudentView()
        {
            /* TODO */
            return View();
        }
    }
}
