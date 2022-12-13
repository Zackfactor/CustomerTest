using System.Linq.Expressions;

namespace CustomerTest.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext _appDbContext;
        public RepositoryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return _appDbContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _appDbContext.Set<T>().Where(expression);
        }
        //[return: MaybeNull]
        public T GetById(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _appDbContext.Set<T>().Find(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _appDbContext.Set<T>().Update(entity);
        }
    }
}
