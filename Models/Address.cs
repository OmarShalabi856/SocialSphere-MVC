using System.ComponentModel.DataAnnotations;

namespace SocialSphere___MVC.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Country { get; set; } = string.Empty;
        [Required]
        public string Town { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
    }
}
