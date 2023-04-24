using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    using EntityLayer.Concretes.Enums;
    using EntityLayer.Concretes.Identity;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using ViewModels.AppUser;

    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager; //Biz burada daha önce olusturgumuz AppUser tablomuzu gösteriyoruz

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Gender = new SelectList(Enum.GetNames(typeof(Gender))); //Enum tipindeki cinsiyetleri Dropdownlist icinde göstermek icin

            ViewBag.City = new SelectList(Enum.GetNames(typeof(City)));
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var identityResult = await _userManager.CreateAsync(new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.Username,
                PhoneNumber = request.PhoneNumber,
                Gender = (int)request.Gender,
                City = (int)request.City
            }, request.PasswordConfirm);

            if (identityResult.Succeeded)
            {
                ViewBag.SuccessMessage = "Üyelik kayıt işlemi başarıyla gerçekleşmiştir. ";

                //return RedirectToAction("Index", "Login");
            }


            foreach (IdentityError item in identityResult.Errors)
            {
                ModelState.AddModelError(string.Empty, item.Description);
            }
            return View();

        }
    }
}
