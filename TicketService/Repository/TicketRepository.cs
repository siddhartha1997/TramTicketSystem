using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketService.Models;

namespace TicketService.Repository
{
    public class TicketRepository : ITicketRepository
    {
        TicketDBContext ticketDB;
        public TicketRepository(TicketDBContext _ticketDB)
        {
            ticketDB = _ticketDB;
        }
        public TicketDetails BookTicket(TicketDetails ticketDetails)
        {
            ticketDB.TicketDetail.Add(ticketDetails);
            ticketDB.SaveChanges();
            return ticketDetails;
        }

        public string CancelTicket(int id)
        {
            //int result = 0;
            if (ticketDB != null)
            {
                var TicketDetail = ticketDB.TicketDetail.FirstOrDefault(x => x.Id == id);
                if (TicketDetail != null)
                {
                    ticketDB.TicketDetail.Remove(TicketDetail);
                    ticketDB.SaveChanges();
                    return "Ticket Cancelled. No refund";
                }
                return null;
            }
            return null;
        }

        public TicketDetails SearchTicket(int id)
        {
            if (ticketDB != null)
            {
                return (ticketDB.TicketDetail.Where(x => x.Id == id)).FirstOrDefault();
            }
            return null;
        }
    }
}
