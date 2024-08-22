using BusinessLogic.Services.Abstracts;
using DataAccess.Repositories.Concretes;

namespace BusinessLogic.Services.Concretes
{
    public class GenericService<TEntiy> : GenericBaseService<TEntiy> where TEntiy : class
    {
        //GenericRepository genericRepository = new GenericRepository();

        private readonly GenericRepository<TEntiy> _genericRepository;
        public GenericService()
        {
            _genericRepository = new GenericRepository<TEntiy>();
        }

        public override List<TEntiy> ListEntity()
        {
            return _genericRepository.ListEntity();
        }
    }
}
