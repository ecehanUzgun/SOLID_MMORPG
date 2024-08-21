namespace DataAccess.Entities.Abstracts
{
    public abstract class Silah
    {
        public int ID { get; set; }
        public int HasarOranı { get; set; }
        public List<Player> Player { get; set; }
        //public abstract int HasarHesapla();
    }
}
