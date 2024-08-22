using DataAccess.Entities;

namespace DataAccess.Data
{
    public class WeaponData
    {
        public static List<Weapon> Weapons = new List<Weapon>()
        {
            new Weapon{ID=1,Name="Staff",Damage=10},
            new Weapon{ID=2,Name="Axe",Damage=8},
            new Weapon{ID=3,Name="Dagger",Damage=4},
            new Weapon{ID=4,Name="Cloak",Damage=2},
            new Weapon{ID=5,Name="Bow",Damage=9}
        };
    }
}
