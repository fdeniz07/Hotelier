namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Contexts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
