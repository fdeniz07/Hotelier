namespace HotelProject.WebUI.Dtos.ServiceDto
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CreateServiceDto
    {

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet basligi giriniz")]
        [StringLength(50,ErrorMessage = "Hizmet basligi en fazla 50 karakter olabilir")]
        public string Title { get; set; }

        [StringLength(100, ErrorMessage = "Hizmet aciklamasi en fazla 1000 karakter olabilir")]
        public string Description { get; set; }

        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }
    }
}
