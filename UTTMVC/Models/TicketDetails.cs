using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTTMVC.Models
{
    public class TicketDetails
    {
        public int Id { get; set; }
        public string Route { get; set; }
        public string TramType { get; set; }
        public string Date { get; set; }
        public int NumberOfPassenger { get; set; }
        public double TicketFare { get; set; }
    }
}
