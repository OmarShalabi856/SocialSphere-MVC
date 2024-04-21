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

        public async Task<IActionResult> Detail(int id)
        {
            var club = await _repository.GetByIdAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            if (!ModelState.IsValid)
            {
                return View(club);
            }

           await _repository.CreateAsync(club);  
            return RedirectToAction("Index");
            
        }
    }
}
