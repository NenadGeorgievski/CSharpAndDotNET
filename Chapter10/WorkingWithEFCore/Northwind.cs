using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore
{
    public class Northwind : DbContext
    {

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
               server =.;
               database =Northwind;
               Integrated Security =true;
               MultipleActiveResultSets =true;

            ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired() //NOT NULL
            .HasMaxLength(15);

            if(ProjectConstants.DatabaseProvider == "SQLServer")
            {
                modelBuilder.Entity<Product>()
                    .Property(product => product.Cost)
                    .HasConversion<double>();
            }
        }
    }
}
