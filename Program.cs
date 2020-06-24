using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using evaluation1.Data;
using evaluation1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace evaluation1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SeedCities();
            //SeedHotels();
            //SeedRole();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void SeedCities()
        {
            using (var db = new Eval1DbContext())
            {
                var Marseille = new City { Name = "Marseille", Country = "France" };
                var Toulouse = new City { Name = "Toulouse", Country = "France" };
                var Naples = new City { Name = "Naples", Country = "Italie" };
                var Londres = new City { Name = "Londres", Country = "Royaume-Uni" };
                var Madrid = new City { Name = "Madrid", Country = "Espagne" };

                db.Add(Marseille);
                db.Add(Toulouse);
                db.Add(Naples);
                db.Add(Londres);
                db.Add(Madrid);

                db.SaveChanges();
            }
        }

        public static void SeedHotels()
        {
            using (var db = new Eval1DbContext())
            {
                var Marseille = new Hotel { Name = "Hôtel Dieu", Phone = "0513453644", Email = "hotelDieu@gmail.com", Adress1 = "12 rue du Vieux Port", CityId = 1, Stars = 5, Rooms = 200 };
                var Toulouse = new Hotel { Name = "Hôtel Raymond IV", Phone = "0561453644", Email = "hotelRaymondIV@gmail.com", Adress1 = "45 rue Bayard", CityId = 2, Stars = 3, Rooms = 130 };
                var Toulouse2 = new Hotel { Name = "Grand Hôtel de l'Opôra", Phone = "0561453644", Email = "grandHotelOpôra@gmail.com", Adress1 = "3 place du Capitole", CityId = 2, Stars = 5 };
                var Naples = new Hotel { Name = "Hôtel San Pietro", Phone = "0561453644", Email = "hotelSanPietro@gmail.com", Adress1 = "Via San Pietro ad Aram", CityId = 3, Stars = 4, Rooms = 400 };
                var Londres = new Hotel { Name = "London house hotel", Phone = "0561453644", Email = "londonHouseHotel@gmail.com", Adress1 = "81 Kensington Gardens Square", Adress2 = "Bayswater", CityId = 4, Stars = 4, Rooms = 200 };
                var Madrid = new Hotel { Name = "Hotel nuevo", Phone = "0561453644", Email = "hotelNuevo@gmail.com", Adress1 = "Calle Bausô", CityId = 5, Stars = 3, Rooms = 300 };

                db.Add(Marseille);
                db.Add(Toulouse);
                db.Add(Toulouse2);
                db.Add(Naples);
                db.Add(Londres);
                db.Add(Madrid);

                db.SaveChanges();
            }
        }

        public static void SeedRole()
        {
            using (var db = new Eval1DbContext())
            {
                var admin = new IdentityRole { Name = "Admin" };

                db.Add(admin);
                db.SaveChanges();
            }
        }
    }
}
