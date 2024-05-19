using SocialSphere___MVC.Data.Enums;
using SocialSphere___MVC.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SocialSphere___MVC.ViewModels
{
    public class EditClubViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }

        public IFormFile? Image { get; set; }

        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public ClubCategory ClubCategory { get; set; }
    }
}
