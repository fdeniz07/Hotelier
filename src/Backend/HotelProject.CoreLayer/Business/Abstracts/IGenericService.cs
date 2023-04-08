namespace HotelProject.CoreLayer.Business.Abstracts
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        void TInsert(TEntity entity);

        void TUpdate(TEntity entity);

        void TDelete(TEntity entity);

        List<TEntity> TGetList();

        TEntity TGetById(int id);
    }
}
