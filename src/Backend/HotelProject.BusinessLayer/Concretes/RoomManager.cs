namespace HotelProject.BusinessLayer.Concretes
{
    using Abstracts;
    using DataAccessLayer.Abstracts;
    using EntityLayer.Concretes;

    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        #region Implementation of IGenericService<Room>

        public void TInsert(Room entity)
        {
            _roomDal.Insert(entity);
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }

        public void TDelete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        #endregion
    }
}
