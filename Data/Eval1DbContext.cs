using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using evaluation1.Models;

namespace evaluation1.Data
{
    public class Eval1DbContext : IdentityDbContext
    {
        /*        public Eval1DbContext(DbContextOptions<Eval1DbContext> options)
                    : base(options)
                {
                }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=evaluation1;Trusted_Connection=True;MultipleActiveResultSets=true"); 

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
