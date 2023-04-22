namespace HotelProject.WebUI.Mapper.AutoMapper.Profile
{
    using EntityLayer.Concretes;
    using global::AutoMapper;
    using WebUI.Dtos.ServiceDto;

    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
        }
    }
}
