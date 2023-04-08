namespace HotelProject.CoreLayer.DataAccess.Abstracts
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);

        void Update(TEntity entity);
        
        void Delete(TEntity entity);
        
        List<TEntity> GetList();
       
        TEntity GetById(int id);
    }
}