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
        public Eval1DbContext(DbContextOptions<Eval1DbContext> options)
            : base(options)
        {
        }

        DbSet<Hotel> Hotels { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Room> Rooms { get; set; }

    }
}
