using Microsoft.AspNetCore.Mvc;

namespace SocialSphere___MVC.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
