using HotelMVC.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string RoomId { get; set; } = new Guid().ToString().Substring(3, 7);
        public string CheckInTime { get; set; } = DateTime.Now.ToString("f");
        public string ExpectedChekoutTime { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public Hotel Hotel { get; set; }
        [Required]
        public IsAvailable IsAvailable { get; set; }
        [Required]
        public double Price { get; set; }



    }
}
