namespace DataAccess.Entities
{
    public class Race
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Energy { get; set; }
        public int Intelligence { get; set; }
        public List<Player> Player { get; set; }
        //public abstract int GetPower(int energy, int intelligence); //power=energy*intelligence
    }
}
