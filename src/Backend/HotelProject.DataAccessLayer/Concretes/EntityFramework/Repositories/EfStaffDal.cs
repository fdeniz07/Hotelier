namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Contexts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
