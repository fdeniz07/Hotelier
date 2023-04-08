namespace HotelProject.BusinessLayer.Concretes
{
    using Abstracts;
    using DataAccessLayer.Abstracts;
    using EntityLayer.Concretes;

    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        #region Implementation of IGenericService<Subscribe>

        public void TInsert(Subscribe entity)
        {
            _subscribeDal.Insert(entity);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribeDal.Update(entity);
        }

        public void TDelete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.GetList();
        }

        public Subscribe TGetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        #endregion
    }
}
