namespace HotelProject.WebUI.Mapper.AutoMapper.Profile
{
    using EntityLayer.Concretes;
    using EntityLayer.Concretes.Identity;
    using global::AutoMapper;
    using ViewModels.AppUser;
    using WebUI.Dtos.ServiceDto;

    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<SignUpViewModel, AppUser>().ReverseMap();
        }
    }
}
