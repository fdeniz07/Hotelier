namespace HotelProject.WebUI.ViewModels.AppUser
{
    using System.ComponentModel.DataAnnotations;
    using EntityLayer.Concretes.Enums;

    public class SignUpViewModel
    {
        public SignUpViewModel(string firstName, string lastName, string userName, string email, string phoneNumber, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public SignUpViewModel() {}

        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        [Display(Name = "Adınız")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        [Display(Name = "Soyadınız")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Kullanıcı alanı boş geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        //[Required(ErrorMessage = "Cinsiyet alanı boş geçilemez")]
        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }

        //[Required(ErrorMessage = "Şehir alanı boş geçilemez")]
        [Display(Name = "Şehir")]
        public City City { get; set; }

        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        [Display(Name = "Email Adresiniz")]
        public string Email { get; set; }

        [Display(Name = "Telefon No")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı boş geçilemez")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        [Display(Name = "Şifre Tekrar")]
        public string PasswordConfirm { get; set; }
    }
}
