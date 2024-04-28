using Microsoft.AspNetCore.Mvc;
using SocialSphere___MVC.Models;
using SocialSphere___MVC.Repository;
using SocialSphere___MVC.Services;
using SocialSphere___MVC.ViewModels;

namespace SocialSphere___MVC.Controllers
{
    public class ClubController : Controller
    {
        public readonly IRepository<Club> _repository;
        public readonly IPhotoService _photoservice;
        public ClubController(IRepository<Club> repository,IPhotoService photoService)
        {
            _repository = repository;
            _photoservice = photoService;
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
        public async Task<IActionResult> Create(CreateClubViewModel clubVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoservice.AddPhotoAsync(clubVM.Image);
                var club = new Club()
                {
                    Title = clubVM.Title,
                    Description = clubVM.Title,
                    Image = result.Url.ToString(),
                    Address = new Address()
                    {
                        Street = clubVM.Address.Street,
                        Town = clubVM.Address.Town, 
                        Country = clubVM.Address.Country,
                    },
                    ClubCategory=clubVM.ClubCategory
                };
                await _repository.CreateAsync(club);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo Upload Failed");
               
            }
            return View(clubVM);
        }
    }
}
