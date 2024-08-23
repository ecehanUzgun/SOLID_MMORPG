using DataAccess.Entities;

namespace BusinessLogic.Services.Concretes
{
    public class RaceService:GenericService<Race>
    {
        public List<Race> ListRaceConsole()
        {
            var races = ListEntity();
            foreach (var race in races)
            {
                Console.WriteLine($"{race.ID} {race.Name} Energy:{race.Energy}");
            }
            return races;
        }
    }
}
