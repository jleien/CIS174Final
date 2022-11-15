﻿using CIS174Final.Areas.TicketList.Models;

namespace CIS174Final.Areas.TicketList.Repository
{
    public interface ITicketRepository
    {
        List<Ticket> GetAllTickets();
        Ticket Find(int id);
        void Save();
        void InsertTicket();
        void UpdateTicket();
        void DeleteTicket();  
    }
}
