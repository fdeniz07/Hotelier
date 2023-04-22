namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Contexts
{
    using EntityLayer.Concretes;
    using EntityLayer.Concretes.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class MsDbContext : IdentityDbContext<AppUser, AppRole, int> //Eger id'lerin int tipinde olmasini istersek belirtiryoruz. Default GUID.
    {
        public MsDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Staff> Staves { get; set; }

        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
