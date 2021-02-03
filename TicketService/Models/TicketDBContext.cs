using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketService.Models
{
    public class TicketDBContext:DbContext
    {
        public TicketDBContext(DbContextOptions options):base(options)
        {

        }
        public TicketDBContext()
        { }
        public virtual DbSet<TicketDetails> TicketDetail { get; set; }
    }
}
