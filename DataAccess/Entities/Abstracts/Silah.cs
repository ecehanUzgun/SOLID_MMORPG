namespace DataAccess.Entities.Abstracts
{
    public class Silah
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HasarOranı { get; set; }
        public List<Player> Player { get; set; }
        //public abstract int HasarHesapla();
    }
}
