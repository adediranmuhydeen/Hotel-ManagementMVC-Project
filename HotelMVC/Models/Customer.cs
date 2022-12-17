using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Customer : Person
    {

        public string CustomerId { get; set; } = new Guid().ToString().Substring(3, 7);
        [Required]
        public string UserName { get; set; }
        public Room Room { get; set; }
        public Hotel Hotel { get; set; }
    }
}
