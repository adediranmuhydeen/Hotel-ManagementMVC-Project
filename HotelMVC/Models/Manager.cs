using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMVC.Models
{
    public class Manager : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //public string ManagerId { get; set; } = new Guid().ToString().Substring(3, 7);
        public string ManagerUserName { get; set; }
        public Hotel Hotel { get; set; }
    }
}
