using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Repository
{
    public interface IUserRepository
    {
        public AccountCreationMessage CreateAccount(UserDetails userDetails);
        public UserDetails UpdateAccount(int id,UserDetails userDetails);
        public UserDetails GetUserDetails(int Id);
        public string DeleteAccount(int Id);
    }
}
