namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Abstracts;
    using Contexts;
    using EntityLayer.Concretes;

    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
