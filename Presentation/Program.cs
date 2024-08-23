using BusinessLogic.Services.Concretes;
using DataAccess.Entities;

namespace Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TODO: Sırayla Player bilgilerini al.

            //Choose Character
            Console.WriteLine("Choose Character\n");
            int userCharacter = 0;
            CharacterService characterService = new CharacterService();

            //Karakterleri listele
            var characters = characterService.ListCharacterConsole();
            
            //Karakter seçimini kullanıcıdan al
            CharacterControl characterControl = new CharacterControl(); 
            characterControl.ControlEntity(ref userCharacter,characters);
            //TODO:Id'si alının karakteri Player'a CharacterId olarak kayıt edilsin.

            //Choose Race
            Console.WriteLine("Choose Race\n");
            int userRace = 0;
            RaceService raceService = new RaceService();

            //Irkları listele
            var races = raceService.ListRaceConsole();

            //Kullanıcı Irk Seçimi
            RaceControl raceControl = new RaceControl();
            raceControl.ControlEntity(ref userRace, races);

            //Silah
            Console.WriteLine("Choose Weapon\n");
            int userWeapon = 0;
            WeaponService weaponService = new WeaponService();

            //Silah Listele
            var weapons = weaponService.ListWeaponConsole();

            //Kullanıcı Silah Seçimi
            WeaponControl weaponControl = new WeaponControl();
            weaponControl.ControlEntity(ref userWeapon, weapons);

            PlayerService playerService = new PlayerService();
            int playerId = 0;

            try
            {
                Console.WriteLine("Kullanıcı Id: ");
                playerId = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Player player = playerService.GetPlayer(playerId);

            if (player == null)
            {
                Player newPlayer = playerService.CreatePlayer();

                Console.WriteLine("Player Name: ");
                newPlayer.PlayerName = Console.ReadLine();
                newPlayer.CharacterId = userCharacter;
                newPlayer.RaceId = userRace;
                newPlayer.WeaponId = userWeapon;

                Console.WriteLine(playerService.SavePlayer(newPlayer)); //Veritabanına kayıt
                player = newPlayer;
            }

            //Oyun Başlayacak
            Console.WriteLine("***Oyuncu Bilgileri***");
            Console.WriteLine($"Oyuncu Ad:{player.PlayerName}");
            Console.WriteLine($"Oyuncu Seviye:{player.Level}");
            Console.WriteLine($"Irk Id:{player.RaceId}");
            Console.WriteLine($"Silah Id:{player.WeaponId}");
            Console.WriteLine($"Character Id:{player.CharacterId}");

            //player kullanarak ırk,silah,karakter adını yazdır.

        }
    }
}
