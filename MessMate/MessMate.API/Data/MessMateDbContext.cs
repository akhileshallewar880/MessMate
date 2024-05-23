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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships and constraints
        modelBuilder.Entity<User>()
            .HasMany<Mess>()
            .WithOne(m => m.Owner)
            .HasForeignKey(m => m.OwnerId)
            .OnDelete(DeleteBehavior.NoAction);  // Adjusted to NoAction

        modelBuilder.Entity<User>()
            .HasMany<Subscription>()
            .WithOne(s => s.User)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.NoAction);  // Adjusted to NoAction

        modelBuilder.Entity<Mess>()
            .HasMany<Subscription>()
            .WithOne(s => s.Mess)
            .HasForeignKey(s => s.MessId)
            .OnDelete(DeleteBehavior.NoAction);  // Adjusted to NoAction

        modelBuilder.Entity<Subscription>()
            .HasMany<Meal>()
            .WithOne(m => m.Subscription)
            .HasForeignKey(m => m.SubscriptionId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<User>()
            .HasMany<Feedback>()
            .WithOne(f => f.User)
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.NoAction);  // Adjusted to NoAction

        modelBuilder.Entity<Mess>()
            .HasMany<Feedback>()
            .WithOne(f => f.Mess)
            .HasForeignKey(f => f.MessId)
            .OnDelete(DeleteBehavior.Cascade);
    }

    }
}