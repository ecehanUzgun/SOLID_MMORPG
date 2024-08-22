using DataAccess.Entities;

namespace BusinessLogic.Services.Abstracts
{
    public abstract class CharacterBaseService
    {
        public abstract List<Character> GetCharacters();
        public abstract void ListCharacter();
    }
}
