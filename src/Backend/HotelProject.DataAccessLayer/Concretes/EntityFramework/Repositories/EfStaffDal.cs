namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Abstracts;
    using Contexts;
    using EntityLayer.Concretes;

    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(MsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
