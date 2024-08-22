namespace DataAccess.Entities
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
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int RaceId { get; set; }
        public Race Race { get; set; }
    }
}
