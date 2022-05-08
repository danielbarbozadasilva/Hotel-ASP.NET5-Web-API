using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
               });
        }

    }
}