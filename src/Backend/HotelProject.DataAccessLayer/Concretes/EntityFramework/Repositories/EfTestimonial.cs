namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Contexts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class EfTestimonial : GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonial(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
