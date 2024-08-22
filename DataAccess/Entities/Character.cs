namespace DataAccess.Entities
{
    public class Character
    {
        //Her bir karakterin silahı olur
        //Dövüşme tipi
        public Character()
        {
            Health = 100;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public int Health { get; set; }
        public List<Player> Player { get; set; }
    }
}
