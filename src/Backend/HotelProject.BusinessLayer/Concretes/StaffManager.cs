namespace HotelProject.BusinessLayer.Concretes
{
    using Abstracts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        #region Implementation of IGenericService<Staff>

        public void TInsert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }

        public void TDelete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public Staff TGetById(Guid id)
        {
            return _staffDal.GetById(id);
        }

        #endregion
    }
}
