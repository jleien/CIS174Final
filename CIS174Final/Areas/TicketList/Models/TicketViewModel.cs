using System.Collections.Generic;

namespace CIS174Final.Areas.TicketList.Models
{
    public class TicketViewModel
    {
        public TicketViewModel()
        {
            CurrentTask = new Ticket();
        }
        public Filters Filters { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Sprint> Sprint { get; set; }
        public int Point { get; set; }
        public List<Status> Statuses { get; set; }

        public Ticket CurrentTask { get; set; }  //used for Add
    }
}
