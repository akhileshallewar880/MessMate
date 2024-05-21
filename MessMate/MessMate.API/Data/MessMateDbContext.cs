using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessMate.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MessMate.API.Data
{
    public class MessMateDbContext : DbContext
    {
        public MessMateDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Mess> Messs { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}