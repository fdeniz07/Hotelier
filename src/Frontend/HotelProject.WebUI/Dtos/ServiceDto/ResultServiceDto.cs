using System.ComponentModel;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class ResultServiceDto
    {
        public int Id { get; set; }

        public string ServiceIcon { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
