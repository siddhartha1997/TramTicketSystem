using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;
using UserService.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;
        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var UserDetails = userRepository.GetUserDetails(id);
                if(UserDetails==null)
                {
                    return NotFound("No such record exist");
                }
                return Ok(UserDetails);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] UserDetails value)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = userRepository.CreateAccount(value);
                    if (res != null)
                        return Ok(res);
                    return NotFound("Account Not Created");
                }
                catch (Exception)
                {
                    return BadRequest("Link Error");
                }
            }
            return BadRequest();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserDetails value)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = userRepository.UpdateAccount(id, value);
                    if (result == null)
                        return BadRequest(result);
                    return Ok(result);
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = userRepository.DeleteAccount(id);
                if (result == null)
                {
                    return BadRequest(result);
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(id);
            }
        }
    }
}
