namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Abstracts;
    using Contexts;
    using EntityLayer.Concretes;

    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(MsDbContext dbContext) : base(dbContext)
        {

        }
    }
}
