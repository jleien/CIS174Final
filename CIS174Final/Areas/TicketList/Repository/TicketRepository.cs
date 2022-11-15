using CIS174Final.Areas.TicketList.Models;

namespace CIS174Final.Areas.TicketList.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private TicketContext context;
        public TicketRepository(TicketContext context)
        {
            this.context = context;
        }

        public List<Ticket> GetAllTickets()
        {
            return context.Tickets.ToList();
        }
        public Ticket Find(int id)
        {
            return context.Tickets.Find(id);
        }
        public void DeleteTicket(Ticket ticket)
        {
            context.Tickets.Remove(ticket);
            context.SaveChanges();
        }

        public void InsertTicket(Ticket ticket)
        {
            context.Tickets.Add(ticket);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
