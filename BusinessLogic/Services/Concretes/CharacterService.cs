using BusinessLogic.Services.Abstracts;
using DataAccess.Entities;
using DataAccess.Repositories.Concretes;

namespace BusinessLogic.Services.Concretes
{
    public class CharacterService : CharacterBaseService
    {
        CharacterRepository characterRepository = new CharacterRepository();
        public override List<Character> GetCharacters()
        {
            return characterRepository.GetAllCharacters();
        }

        public override void ListCharacter()
        {
           var characters = characterRepository.GetAllCharacters();
            foreach (var character in characters)
            {
                Console.WriteLine($"{character.Name} Skill:{character.Skill} Health:{character.Health}");
            }
        }
    }
}
