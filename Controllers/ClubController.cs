using Microsoft.AspNetCore.Mvc;
using SocialSphere___MVC.Models;
using SocialSphere___MVC.Repository;

namespace SocialSphere___MVC.Controllers
{
    public class ClubController : Controller
    {
        public readonly IRepository<Club> _repository;
        public ClubController(IRepository<Club> repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var clubs = await _repository.GetAllAsync();
            return View(clubs);
        }
    }
}
