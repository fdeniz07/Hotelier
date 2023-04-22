namespace HotelProject.WebUI.Dtos.AppUser
{
    using System.ComponentModel.DataAnnotations;
    using EntityLayer.Concretes.Enums;

    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad alani bos gecilemez")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alani bos gecilemez")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Kullanici adi alani bos gecilemez")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Cinsiyet alani bos gecilemez")]
        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }


        [Required(ErrorMessage = "Email alani bos gecilemez")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Sifre alani bos gecilemez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre tekrar alani bos gecilemez")]
        [Compare("Password", ErrorMessage = "Sifreler uyusmuyor")]
        public string ConfirmPassword { get; set; }


    }
}
