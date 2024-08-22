using BusinessLogic.Services.Concretes;
using DataAccess.Entities;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Oyuncu Oluştur
            //Console.WriteLine("***Create Player***");
            //Console.WriteLine("Player Name:");
            //string playerName = Console.ReadLine();
            ////Choose Caracter
            //Console.WriteLine("Choose Character");
            //CharacterService characterService = new CharacterService();
            //characterService.ListCharacter();
            //int userCharacter = int.Parse(Console.ReadLine());
            //Choose Race
            Console.WriteLine("Choose Race");
            RaceService raceService = new RaceService();
            var races = raceService.ListEntity();
            foreach(var race in races) 
            {
                Console.WriteLine($"{race.ID} {race.Name} {race.Intelligence} {race.Energy}");
            }


        }   
    }
}
