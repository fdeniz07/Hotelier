using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class StavesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
