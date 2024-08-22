using DataAccess.Entities;

namespace DataAccess.Repositories.Abstracts
{
    public abstract class BaseGenericRepository<TEntity>
    {
        //Generic Repository
        public abstract List<TEntity> ListEntity();
    }
}
