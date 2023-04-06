namespace HotelProject.BusinessLayer.Concretes
{
    using Abstracts;
    using EntityLayer.Abstracts;
    using EntityLayer.Concretes;

    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        #region Implementation of IGenericService<Testimonial>

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public Testimonial TGetById(Guid id)
        {
            return _testimonialDal.GetById(id);
        }

        #endregion
    }
}
