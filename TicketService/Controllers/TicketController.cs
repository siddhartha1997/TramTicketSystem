using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketService.Models;
using TicketService.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicketService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        ITicketRepository ticketRepository;
        public TicketController(ITicketRepository _ticketRepository)
        {
            ticketRepository = _ticketRepository;
        }
        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var TicketDetails = ticketRepository.SearchTicket(id);
                if (TicketDetails == null)
                    return NotFound("No such ticket generated");
                return Ok(TicketDetails);
            }
            catch(Exception)
            {
                return BadRequest("Link Failure");
            }
        }

        // POST api/<TicketController>
        [HttpPost]
        public IActionResult Post([FromBody] TicketDetails value)
        {
            try
            {
                var GenerateTicket = ticketRepository.BookTicket(value);
                if(GenerateTicket==null)
                {
                    return NotFound("Error");
                }
                return Ok(GenerateTicket);
            }
            catch(Exception)
            {
                return BadRequest("Link Failure");
            }
        }

        // PUT api/<TicketController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var CancelTicket = ticketRepository.CancelTicket(id);
                if(CancelTicket==null)
                {
                    return NotFound("No such id present");
                }
                return Ok(CancelTicket);
            }
            catch
            {
                return BadRequest("Link Failure");
            }
        }
    }
}
