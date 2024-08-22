using DataAccess.Entities;

namespace DataAccess.Repositories.Abstracts
{
    public abstract class CharacterBaseRepository
    {
        public abstract List<Character> GetAllCharacters();
    }
}
