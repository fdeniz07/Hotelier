using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    using Dtos.AppUser;
    using EntityLayer.Concretes.Identity;
    using HotelProject.EntityLayer.Concretes.Enums;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager; //Biz burada daha önce olusturgumuz AppUser tablomuzu gösteriyoruz

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Gender = new SelectList(Enum.GetNames(typeof(Gender))); //Enum tipindeki cinsiyetleri Dropdownlist icinde göstermek icin
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser()
            {
                FirstName = createNewUserDto.FirstName,
                LastName = createNewUserDto.LastName,
                Email = createNewUserDto.Email,
                UserName = createNewUserDto.Username,
                Gender = (int)createNewUserDto.Gender
              
            };
            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
