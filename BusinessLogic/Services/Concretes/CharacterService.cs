using BusinessLogic.Services.Abstracts;
using DataAccess.Entities;
using DataAccess.Repositories.Concretes;

namespace BusinessLogic.Services.Concretes
{
    public class CharacterService : GenericService<Character>
    {
        public List<Character> ListCharacterConsole()
        {
            var characters = ListEntity();
            foreach (var character in characters)
            {
                Console.WriteLine($"{character.ID} {character.Name} Skill:{character.Skill} Health:{character.Health}");
            }
            return characters;
        }
    }
}
