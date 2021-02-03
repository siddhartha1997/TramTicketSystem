using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class UserDBContext:DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options)
        { }
        public UserDBContext()
        {

        }
        public virtual DbSet<UserDetails> Users { get; set; }
    }
}
