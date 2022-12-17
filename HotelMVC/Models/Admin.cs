using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Admin : Person
    {
        public int Id { get; set; }
        public string AdminId { get; set; } = new Guid().ToString().Substring(8, 7);
        [Required]
        public string AdminName { get; set; }
        public Hotel Hotel { get; set; }


    }
}
