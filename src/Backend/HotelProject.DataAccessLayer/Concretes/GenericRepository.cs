namespace HotelProject.DataAccessLayer.Concretes
{
    using CoreLayer.DataAccess.Abstracts;
    using EntityFramework.Contexts;

    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        private readonly MsDbContext _dbContext;

        public GenericRepository(MsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(TEntity entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<TEntity> GetList()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
    }
}
