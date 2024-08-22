using DataAccess.Entities;

namespace DataAccess.Data
{
    public class RaceData
    {
        public static List<Race> Races = new List<Race>()
        {
            new Race{ID=1,Name="Dwarf",Energy=175,Intelligence=75},
            new Race{ID=2,Name="Elf",Energy=150,Intelligence=250},
            new Race{ID=3,Name="Human",Energy=150,Intelligence=150},
            new Race{ID=4,Name="Orc",Energy=250,Intelligence=20}
        };
    }
}
