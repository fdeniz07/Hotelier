namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Abstracts;
    using Contexts;
    using EntityLayer.Concretes;

    public class EfTestimonial : GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonial(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
