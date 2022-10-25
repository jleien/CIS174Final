using CIS174Final.Areas.TicketList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static NuGet.Packaging.PackagingConstants;

namespace CIS174Final.Areas.TicketList.Controllers
{
    [Area("TicketList")]
    public class TicketController : Controller
    {
        private readonly TicketContext context;
        
        public TicketController(TicketContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            //store current filters and data needed for filter drop downs in TicketViewModel
            TicketViewModel model = new();

            var filters = new Filters(id);

            model.Filters = new Filters(id);
            model.Sprint = context.Sprints.ToList();
            model.Statuses = context.Statuses.ToList();


            // get Ticket objects from database based on current filters
            IQueryable<Ticket> query = context.Tickets.Include(t => t.SprintId).Include(t => t.Status);
            if (filters.HasSprint)
            {
                query = query.Where(t => t.SprintId == filters.SprintId);
            }
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }
            return View(model);
        }

        public IActionResult Add()
        {
            TicketViewModel model = new()
            {
                Sprint = context.Sprints.ToList(),
                Statuses = context.Statuses.ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(TicketViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Tickets.Add(model.CurrentTask);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                model.Sprint = context.Sprints.ToList();
                model.Statuses = context.Statuses.ToList();
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, Ticket selected)
        {
            if (selected.StatusId == null)
            {
                context.Tickets.Remove(selected);
            }
            else
            {
                string newStatusId = selected.StatusId;
                selected = context.Tickets.Find(selected.Id);
                selected.StatusId = newStatusId;
                context.Tickets.Update(selected);
            }
            context.SaveChanges();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}

