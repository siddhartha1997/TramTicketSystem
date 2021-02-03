using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Repository
{
    public class UserRepository : IUserRepository
    {
        UserDBContext UserDB;
        public UserRepository(UserDBContext _UserDB)
        {
            UserDB = _UserDB;
        }
        public AccountCreationMessage CreateAccount(UserDetails userDetails)
        {
            userDetails.PhoneNumber = (Int64)userDetails.PhoneNumber;
            UserDB.Users.Add(userDetails);
            UserDB.SaveChanges();
            AccountCreationMessage accountCreationMessage = new AccountCreationMessage
            {
                CreationStatus = "Account Created",
                Id = userDetails.Id
            };
            return accountCreationMessage;
        }

        public string DeleteAccount(int Id)
        {
            if (UserDB != null)
            {
                var post = UserDB.Users.FirstOrDefault(x => x.Id == Id);
                if (post != null)
                {
                    UserDB.Users.Remove(post);
                    UserDB.SaveChanges();
                    return "Removed Successfully";
                }
                return null;
            }
            return null;
        }

        public UserDetails GetUserDetails(int Id)
        {
            if (UserDB != null)
            {
                return (UserDB.Users.Where(x => x.Id == Id)).FirstOrDefault();
            }
            return null;
        }

        public UserDetails UpdateAccount(int id, UserDetails userDetails)
        {
            if (UserDB != null)
            {
                var obj = (UserDB.Users.Where(x => x.Id == id)).FirstOrDefault();
                if (obj != null)
                {
                    //obj.Name = userDetails.Name;
                    //obj.LastName = boarder.LastName;
                    //obj.Email = boarder.Email;
                    if(userDetails.Password!=null)
                        obj.Password = userDetails.Password;
                    if(userDetails.Address!=null)
                        obj.Address = userDetails.Address;
                    UserDB.SaveChanges();
                    return (UserDB.Users.Where(x => x.Id == id)).FirstOrDefault(); ;
                }
            }
            return null;
        }
    }
}
