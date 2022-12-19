using HotelMVC.Enums;
using HotelMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelMVC.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(new Admin
            {
                FirstName = "Olayinka",
                MiddleName = "David",
                LastName = "Sulaiman",
                Email = "admin@example.com",
                Password = "admin",
                PhoneNumber = "08089765432",
                Title = Title.Dr,
                AdminName = "firstAdmin",
                HotelId = 1
            });
        }
    }
}
