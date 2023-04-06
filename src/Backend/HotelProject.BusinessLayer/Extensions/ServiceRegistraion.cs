namespace HotelProject.BusinessLayer.Extensions
{
    using Abstracts;
    using Concretes;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceRegistraion
    {
        public static void AddBusinessLayerServices(this IServiceCollection services)
        {
            //IOC Container'e eklenmesi icin BusinessLayer katmanindaki abstract ve concrete objeleri geciyoruz
            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IStaffService, StaffManager>();
            services.AddScoped<ISubscribeService, SubscribeManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
        }
    }
}
