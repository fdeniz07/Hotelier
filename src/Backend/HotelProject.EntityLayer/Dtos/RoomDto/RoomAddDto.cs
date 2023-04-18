namespace HotelProject.EntityLayer.Dtos.RoomDto
{
    using System.ComponentModel.DataAnnotations;
    using CoreLayer.Entity.Base;

    public class RoomAddDto:IDto
    {
        [Required(ErrorMessage = "Lütfen oda numarasini giriniz")]
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda basligini giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayisini giriniz")]
        public int BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayisini giriniz")]
        public int BathCount { get; set; }

        public bool Wifi { get; set; }

        public string Description { get; set; }
    }
}
