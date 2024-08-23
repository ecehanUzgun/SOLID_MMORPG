using DataAccess.Entities;

namespace BusinessLogic.Services.Concretes
{
    public class WeaponService:GenericService<Weapon>
    {
        public List<Weapon> ListWeaponConsole()
        {
            var weapons = ListEntity();
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"{weapon.ID} {weapon.Name} Damage:{weapon.Damage}");
            }
            return weapons;
        }
    }
}
