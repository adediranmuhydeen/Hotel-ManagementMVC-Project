using HotelMVC.Enums;
using HotelMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HotelMVC.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(new Room
            {
                Id = 1,
                CheckInTime = DateTime.Now.ToString("f"),
                RoomName = "LasVegas",
                RoomNumber = 110,
                RoomType = RoomType.SingleRoom,
                IsAvailable = IsAvailable.Available,
                Price = 15000.00,
                HotelId = 1
            });
        }
    }
}
