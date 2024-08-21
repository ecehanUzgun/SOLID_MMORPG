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
        //Foreign Key
        public int SilahId { get; set; }
        public Silah Silah { get; set; }
        public int CharacterId {  get; set; }
        public Character Character { get; set; }
        public int IrkId { get; set; }
        public Irk Irk { get; set; }
    }
}
