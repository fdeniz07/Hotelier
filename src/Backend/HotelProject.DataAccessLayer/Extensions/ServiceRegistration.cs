namespace HotelProject.DataAccessLayer.Extensions
{
    using Abstracts;
    using Concretes.EntityFramework.Contexts;
    using Concretes.EntityFramework.Repositories;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceRegistration
    {
        public static void AddDataAccessLayerServices(this IServiceCollection services)
        {
            //ConnectionStringimizi de burada geciyoruz.
            services.AddDbContext<MsDbContext>(option => option.UseSqlServer(Configuration.ConnectionString));


            //IOC Container'e eklenmesi icin DataAccess katmanindaki abstract ve concrete objeleri geciyoruz
            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<ITestimonialDal, EfTestimonial>();
        }
    }
}
