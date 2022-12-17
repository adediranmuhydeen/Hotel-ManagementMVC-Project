using HotelMVC.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public abstract class Person
    {
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Title Title { get; set; }
        [Required]
        public string FullName { get { if (MiddleName == null) { return Title + " " + FirstName + " " + LastName; } return Title + " " + FirstName + ", " + MiddleName + " " + LastName; } }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
