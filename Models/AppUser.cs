namespace SocialSphere___MVC.Models
{
    public class AppUser
    {
        public int? Pace { get; set; }

        public int? Mileage { get; set; }

        public Address? Address { get; set; }

        public List<Race> Races { get; set; } = [];
        public List<Club> Clubs { get; set; } = [];

    }
}
