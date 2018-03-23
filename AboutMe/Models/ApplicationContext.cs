using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AboutMe.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts)
            : base(opts)
        {
        }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        

    }
}
