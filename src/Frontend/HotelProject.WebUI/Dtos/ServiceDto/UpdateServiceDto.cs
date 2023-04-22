namespace HotelProject.WebUI.Dtos.ServiceDto
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class UpdateServiceDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet basligi giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet basligi en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [StringLength(100, ErrorMessage = "Hizmet aciklamasi en fazla 1000 karakter olabilir")]
        public string Description { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
