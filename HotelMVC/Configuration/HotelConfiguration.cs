using HotelMVC.Enums;
using HotelMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelMVC.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(new Hotel
            {
                Id = 1,
                HotelName = "Paradise",
                Address = "grater Manchester",
                City = "manchester",
                EmailAddress = "hotel@excample.com",
                PhoneNumber = "08098765432",
                State = "United Kingdom",
                Rating = HotelRating.FiveStar,
                ManagerId = 1
            });
        }
    }
}
