using DataAccess.Context;
using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories.Concretes
{
    public class CharacterRepository : CharacterBaseRepository
    {
        private readonly MmorpgContext db= new MmorpgContext();
        public override List<Character> GetAllCharacters()
        {
            return db.Characters.ToList();
        }
    }
}
