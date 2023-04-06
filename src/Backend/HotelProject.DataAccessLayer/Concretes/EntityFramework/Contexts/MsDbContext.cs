namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Contexts
{
    using EntityLayer.Concretes;
    using Microsoft.EntityFrameworkCore;

    public class MsDbContext : DbContext
    {
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
