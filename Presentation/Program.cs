using BusinessLogic.Services.Concretes;
using DataAccess.Entities;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Choose Character
            Console.WriteLine("Choose Character\n");
            int userCharacter = 0;
            CharacterService characterService = new CharacterService();

            //Karakterleri listele
            var characters = characterService.ListCharacterConsole();
            
            //Karakter seçimini kullanıcıdan al
            CharacterControl characterControl = new CharacterControl(); 
            characterControl.ControlEntity(userCharacter,characters);

            //Choose Race
            Console.WriteLine("Choose Race");
            int userRace = 0;
            RaceService raceService = new RaceService();

            //Irkları listele
            var races = raceService.ListRaceConsole();

            //Kullanıcı 
            RaceControl raceControl = new RaceControl();
            raceControl.ControlEntity(userRace, races);


        }   
    }
}
