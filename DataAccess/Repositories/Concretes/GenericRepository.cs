using DataAccess.Context;
using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Formats.Tar;

namespace DataAccess.Repositories.Concretes
{
    public class GenericRepository<TEntity>:BaseGenericRepository<TEntity> where TEntity : class
    {
        private readonly MmorpgContext db = new MmorpgContext();

        private readonly DbSet<TEntity> _object;

        public GenericRepository()
        {
            _object = db.Set<TEntity>();
        }

        public override List<TEntity> ListEntity()
        {
            return _object.ToList();
        }
    }
}
