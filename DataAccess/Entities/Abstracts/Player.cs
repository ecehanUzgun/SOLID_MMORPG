namespace DataAccess.Entities.Abstracts
{
    public class Player
    {
        public Player()
        {
            CreatedDate = DateTime.Now;
            Level = 1;
        }
        public int ID { get; set; }
        public string PlayerName { get; set; }
        public int Level { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
