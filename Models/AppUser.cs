using System.ComponentModel.DataAnnotations;

namespace SocialSphere___MVC.Models
{
    public class AppUser
    {
        [Key]
        public string id {  get; set; }
        public int? Pace { get; set; }

        public int? Mileage { get; set; }

        public Address? Address { get; set; }
        public List<Club> Clubs { get; set; } = [];

    }
}
