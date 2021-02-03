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
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44352/api");
        HttpClient client;
        public static int UserId;
        public UserController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Authentication(ExistingUserDetails existingUserDetails)
        {
            int id = existingUserDetails.Id;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/User/" + id).Result;
            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var usersearchresult = JsonConvert.DeserializeObject<UserDetails>(data);
                if(usersearchresult!=null && usersearchresult.Password==existingUserDetails.Password)
                {
                    UserId = id;
                    return RedirectToAction("Index", "Booking");
                }
                return RedirectToAction("Error");
            }
            else
            {
                return BadRequest("Link Failure");
            }
        }
        public IActionResult Logoff()
        {
            return View();
        }
        public IActionResult CreateAccount(UserDetails userDetails)
        {
            string data = JsonConvert.SerializeObject(userDetails);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/User/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                string AccountCreationStatus = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<AccountCreationMessage>(AccountCreationStatus);
                if (result != null)
                    return RedirectToAction("AccountCreationStatus", result);
                else
                    return RedirectToAction("Error");
            }
            return BadRequest("Link Failure");
        }
        public IActionResult AccountCreationStatus(AccountCreationMessage accountCreationMessage)
        {
            return View(accountCreationMessage);
        }
        public IActionResult GetAccountDetails()
        {
            int id = UserId;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/User/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var usersearchresult = JsonConvert.DeserializeObject<UserDetails>(data);
                if (usersearchresult != null)
                {
                    return RedirectToAction("ProfileDetails", usersearchresult);
                }
                return RedirectToAction("Error");
            }
            else
            {
                return BadRequest("Link Failure");
            }
        }
        public IActionResult ProfileDetails(UserDetails userDetails)
        {
            return View(userDetails);
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult ProfileEdit(UserDetails userDetails)
        {
            int id = UserId;
            string data = JsonConvert.SerializeObject(userDetails);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/User/" + id,content).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var usersearchresult = JsonConvert.DeserializeObject<UserDetails>(result);
                if (usersearchresult != null)
                {
                    return RedirectToAction("GetAccountDetails");
                }
                return RedirectToAction("Error");
            }
            else
            {
                return BadRequest("Link Failure");
            }
        }
        public IActionResult Delete()
        {
            int id = UserId;
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/User/" + id).Result;
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return BadRequest("Link Failure");
            }
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
