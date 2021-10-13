using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.Data
{
    public class VogCodeChallengeContext : DbContext
    {
        public VogCodeChallengeContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }

        public void OnConfiguring(ApplicationBuilder app, DbContextOptionsBuilder optionsBuilder)
        { 
         
          
        }
       

    }
}

