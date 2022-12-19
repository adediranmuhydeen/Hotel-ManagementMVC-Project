using HotelMVC.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMVC.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CheckInTime { get; set; } = DateTime.Now.ToString("f");
        public string ExpectedChekoutTime { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
        [Required]
        public IsAvailable IsAvailable { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
