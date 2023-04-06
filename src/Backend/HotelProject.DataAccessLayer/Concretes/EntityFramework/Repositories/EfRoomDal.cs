namespace HotelProject.DataAccessLayer.Concretes.EntityFramework.Repositories
{
    using Contexts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(MsDbContext dbContext) : base(dbContext)
        {

        }
    }
}
