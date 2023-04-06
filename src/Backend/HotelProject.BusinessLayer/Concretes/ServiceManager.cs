namespace HotelProject.BusinessLayer.Concretes
{
    using Abstracts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        #region Implementation of IGenericService<Service>

        public void TInsert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }

        public void TDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public Service TGetById(Guid id)
        {
            return _serviceDal.GetById(id);
        }

        #endregion
    }
}
