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

            //Choose Caracter
            Console.WriteLine("Choose Character\n");
            int userCharacter = 0;
            CharacterService characterService = new CharacterService();
            var characters = characterService.ListEntity();
            foreach(var character in characters)
            {
                Console.WriteLine($"{character.ID} {character.Name} Skill:{character.Skill} Health:{character.Health}");
            }
            //Kullanının seçtiği karakter veritabanına kayıt edilsin.
                try
                {
                    userCharacter = int.Parse(Console.ReadLine());
                    if (userCharacter > 0 && userCharacter <= characters.Count) 
                    {
                        Console.WriteLine($"{characters[userCharacter-1].Name} karakterini seçtiniz.\n");
                    }
                    else 
                    {
                        Console.WriteLine("Lütfen listedeki karakterlerden birini seçin.\n");
                        userCharacter = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
            //Choose Race
            Console.WriteLine("Choose Race");
            int userRace = 0;
            RaceService raceService = new RaceService();
            var races = raceService.ListEntity();
            foreach(var race in races) 
            {
                Console.WriteLine($"{race.ID} {race.Name} Intelligence:{race.Intelligence} Energy:{race.Energy}");
            }
            try
            {
                userRace = int.Parse(Console.ReadLine());
                if (userRace > 0 && userRace <= races.Count)
                {
                    Console.WriteLine($"{races[userRace - 1].Name} ırkını seçtiniz.\n");
                }
                else
                {
                    Console.WriteLine("Lütfen listedeki ırklardan birini seçin.\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //try catch metot oluştur.
        }   
    }
}
