namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Abstracts;
    using Contexts;
    using EntityLayer.Concretes;

    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
