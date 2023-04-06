namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Contexts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
