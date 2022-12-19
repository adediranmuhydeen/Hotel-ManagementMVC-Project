using HotelMVC.Enums;
using HotelMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelMVC.Configuration
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasData(new Manager
            {
                Id = 1,
                ManagerUserName = "FirstManager",
                FirstName = "John",
                LastName = "enjamine",
                Email = "manager@example.com",
                Password = "manager",
                PhoneNumber = "08061695555",
                Title = Title.Mr,
                HotelId = 1
            });
        }
    }
}
