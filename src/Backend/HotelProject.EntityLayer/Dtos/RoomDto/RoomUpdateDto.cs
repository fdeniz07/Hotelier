using HotelProject.CoreLayer.Entity.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Dtos.RoomDto
{
    public class RoomUpdateDto : IDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasini giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görselini giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda basligini giriniz")]
        [StringLength(100,ErrorMessage = "Lütfen en fazla 100 karakter veri girisi yapiniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayisini giriniz")]
        public int BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayisini giriniz")]
        public int BathCount { get; set; }

        public bool Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen aciklamayi yaziniz")]
        public string Description { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
