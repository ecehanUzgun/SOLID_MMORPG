using DataAccess.Entities;

namespace DataAccess.Data
{
    public class CharacterData
    {
        public static List<Character> Characters = new List<Character>()
        {
            new Character{ID=1,Name="Hunter",Skill="Hunting"},
            new Character{ID=2,Name="Mage",Skill="Spell"},
            new Character{ID=3,Name="Rogue",Skill="Stab"},
            new Character{ID=4,Name="Warrior",Skill="Slash"}
        };
    }
}
