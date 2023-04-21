using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class SubscribesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
