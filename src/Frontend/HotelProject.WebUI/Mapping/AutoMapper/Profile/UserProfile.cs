namespace HotelProject.WebUI.Mapping.AutoMapper.Profile
{
    using EntityLayer.Concretes;
    using EntityLayer.Dtos.RoomDto;
    using global::AutoMapper;

    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<RoomAddDto, Room>();
        }
    }
}
