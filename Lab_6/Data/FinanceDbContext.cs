using Lab_6.Data.Models;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace Lab_6.Data
{
    public class FinanceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options) { 

            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Tom", Email = "TomEmail", Password = "123"},
            new User { Id = 2, Name = "Bob", Email = "BobEmail", Password = "456"},
            new User { Id = 3, Name = "Sam", Email = "SamEmail", Password = "789"}
            );
        }
    }
}
