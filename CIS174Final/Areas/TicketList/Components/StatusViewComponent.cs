using CIS174Final.Areas.TicketList.Models;
using Microsoft.AspNetCore.Mvc;
using CIS174Final.Areas.TicketList.Repository;

namespace CIS174Final.Areas.TicketList.Components
{
    public class StatusViewComponent : ViewComponent
    {
        private Ticket ticket { get; set; }
        public StatusViewComponent(Ticket t)
        {
            ticket = t;
        }
        public IViewComponentResult Invoke(Ticket t)
        {
            return View();
        }
    }
}
