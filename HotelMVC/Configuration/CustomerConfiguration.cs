using HotelMVC.Enums;
using HotelMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelMVC.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(new Customer
            {
                FirstName = "Waris",
                LastName = "Salami",
                Email = "customer@example.com",
                Password = "customer",
                PhoneNumber = "08089765432",
                Title = Title.Dr,
                Id = 1,
                RoomId = 1,
                HotelId = 1
            });
        }
    }
}
