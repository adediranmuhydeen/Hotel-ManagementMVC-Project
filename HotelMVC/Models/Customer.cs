using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMVC.Models
{
    public class Customer : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
    }
}
