using DataAccess.Entities;

namespace DataAccess.Repositories.Abstracts
{
    public abstract class RaceBaseRepository
    {
        public abstract List<Race> GetAllRaces();
    }
}
