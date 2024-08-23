using BusinessLogic.Services.Concretes;
using DataAccess.Entities;

namespace Presentation
{
    public class Program
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
            //TODO:Id'si alının karakteri Player'a CharacterId olarak kayıt edilsin.

            //Choose Race
            Console.WriteLine("Choose Race\n");
            int userRace = 0;
            RaceService raceService = new RaceService();

            //Irkları listele
            var races = raceService.ListRaceConsole();

            //Kullanıcı Irk Seçimi
            RaceControl raceControl = new RaceControl();
            raceControl.ControlEntity(userRace, races);

            //Silah
            Console.WriteLine("Choose Weapon\n");
            int userWeapon = 0;
            WeaponService weaponService = new WeaponService();

            //Silah Listele
            var weapons = weaponService.ListWeaponConsole();


        }   
    }
}
