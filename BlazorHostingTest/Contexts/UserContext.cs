using System;
using BlazorHostingTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorHostingTest.Contexts
{
    public class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User()
                    {
                        Id = 1,
                        Name = "Satoru",
                        LastName = "Gojo"
                    },
                    new User()
                    {
                        Id = 2,
                        Name = "Yuji",
                        LastName = "Itadori"
                    },
                    new User()
                    {
                        Id = 3,
                        Name = "Megumi",
                        LastName = "Fushiguro"
                    },
                    new User()
                    {
                        Id = 4,
                        Name = "Nobara",
                        LastName = "Kugisaki"
                    });
        }
    }
}
