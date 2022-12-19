using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMVC.Models
{
    public class Admin : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string AdminName { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }

    }
}
