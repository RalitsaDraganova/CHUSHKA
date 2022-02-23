using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Data
{
    public class CHUSHKADbContext:DbContext
    {
        //Constructors
        public CHUSHKADbContext()
        {
            
        }

        public CHUSHKADbContext(DbContextOptions<CHUSHKADbContext> options) : base(options)
        {
            
        }

      //Tables
      public virtual DbSet<User> Users { get; set; }
      public virtual DbSet<Product> Products { get; set; }
      public virtual DbSet<Order> Orders { get; set; }
        
    }
}
