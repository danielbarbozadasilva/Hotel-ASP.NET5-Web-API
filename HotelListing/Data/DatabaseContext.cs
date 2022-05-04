using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Brasil",
                    ShortName = "BR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Argentina",
                    ShortName = "ARG"
                },
                new Country
                {
                    Id = 3,
                    Name = "Jamaica",
                    ShortName = "JM"
                }
            );
            builder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Hotel Resort abc",
                   Address = "Rua abc",
                   CountryId = 1,
                   Rating = 4.6
               },
               new Hotel
               {
                   Id = 2,
                   Name = "Hotel avdvd",
                   Address = "Rua abc",
                   CountryId = 2,
                   Rating = 4.8
               },
               new Hotel
               {
                   Id = 3,
                   Name = "Hotel abc",
                   Address = "Rua abc",
                   CountryId = 3,
                   Rating = 3.9
               }
           );
        }


    }
}
