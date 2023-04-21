namespace HotelProject.WebApi.Mapper.AutoMapper.Profile
{
    using EntityLayer.Concretes;
    using EntityLayer.Dtos.RoomDto;
    using global::AutoMapper;

    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<RoomUpdateDto, Room>().ReverseMap(); //Yukaridaki gibi ayri ayri yazmaktansa ReverseMap() metodu ile tersi yönde de mapp'leme yapabiliyoruz.
        }
    }
}
