using System.Collections.Generic;

namespace CIS174Final.Areas.TicketList.Models
{
    public class TicketViewModel
    {
        public TicketViewModel()
        {
            Ticket = new Ticket();
        }*/
        
        public List<Ticket> Tickets { get; set; }  //used for Add
       // public Filters Filters { get; set; }
    }
}
