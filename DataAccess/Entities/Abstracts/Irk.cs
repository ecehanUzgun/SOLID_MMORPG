namespace DataAccess.Entities.Abstracts
{
    public class Irk
    {
        public int ID { get; set; }
        public int Energy { get; set; }
        public int Intelligence { get; set; }
        //public abstract int GetPower(int energy, int intelligence); //power=energy*intelligence
    }
}
