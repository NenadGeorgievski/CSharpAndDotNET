using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models.Entities;

namespace MyFirstMVC.Data
{
    public class FirstContext : DbContext
    {
        public FirstContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonDetails> PersonDetails { get; set; }

       
    }
}
