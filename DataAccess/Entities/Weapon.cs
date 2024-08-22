namespace DataAccess.Entities
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<Player> Player { get; set; }
        //public abstract int HasarHesapla();
    }
}
