using HotelMVC.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMVC.Models
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //public string HotelId { get; set; } = new Guid().ToString().Substring(7, 7);
        [Required(ErrorMessage = "Hotel name is required")]
        [MaxLength(35)]
        public string HotelName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public HotelRating Rating { get; set; }
        public Manager Manager { get; set; }
        public int ManagerId { get; set; }
        //public int AdminId { get; set; }
        //[ForeignKey("Id")]
        public ICollection<Admin> Admins { get; set; }
        //public int RoomId { get; set; }
        //[ForeignKey("Id")]
        public ICollection<Room> Rooms { get; set; }
        //public int CustomerId { get; set; }
        //[ForeignKey("Id")]
        public ICollection<Customer> Customers { get; set; }

        public Hotel()
        {
            Admins = new HashSet<Admin>();
            Customers = new HashSet<Customer>();
            Rooms = new HashSet<Room>();
        }
    }
}
