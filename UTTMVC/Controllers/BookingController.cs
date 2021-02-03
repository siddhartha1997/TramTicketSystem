using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UTTMVC.Models;

namespace UTTMVC.Controllers
{
    public class BookingController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44313/api");
        HttpClient client;
        public static int PNR;
        public BookingController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookTicket(TicketDetails ticketDetails)
        {
            string data = JsonConvert.SerializeObject(ticketDetails);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Ticket/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                string AccountCreationStatus = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<TicketDetails>(AccountCreationStatus);
                if (result != null)
                    return RedirectToAction("PrintTicket", result);
                else
                    return RedirectToAction("Error");
            }
            return BadRequest("Link Failure");
        }
        public IActionResult PrintTicket(TicketDetails result)
        {
            return View(result);
        }
        public IActionResult GetTicketDetails()
        {
            return View();
        }
        public IActionResult GetTicketInformation(TicketId ticketId)
        {
            int id = ticketId.Id;
            PNR = id;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Ticket/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var ticketsearchresult = JsonConvert.DeserializeObject<TicketDetails>(data);
                if (ticketsearchresult != null)
                {
                    return RedirectToAction("TicketInformation", ticketsearchresult);
                }
                return RedirectToAction("Error");
            }
            else
            {
                return BadRequest("Link Failure");
            }
        }
        public IActionResult TicketInformation(TicketDetails ticketDetails)
        {
            return View(ticketDetails);
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult CancelTicket(TicketId ticketId)
        { 
            int id = ticketId.Id;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Ticket/" + id).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            var ticketsearchresult = JsonConvert.DeserializeObject<TicketDetails>(data);
            HttpResponseMessage delResponse = client.DeleteAsync(client.BaseAddress + "/Ticket/" + id).Result;
            if (delResponse.IsSuccessStatusCode)
            {
                //return RedirectToAction("Index");
                return RedirectToAction("CancelTicketStatus",ticketsearchresult);
            }
            else
            {
                return BadRequest("Link Failure");
            }
        }
        public IActionResult CancelTicketStatus(TicketDetails ticketDetails)
        {
            return View(ticketDetails);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
