using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}