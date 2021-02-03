using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketService.Models;

namespace TicketService.Repository
{
    public interface ITicketRepository
    {
        public TicketDetails BookTicket(TicketDetails ticketDetails);
        public TicketDetails SearchTicket(int id);
        public string CancelTicket(int id);
    }
}
