﻿namespace DataAccess.Entities.Abstracts
{
    public class Character
    {
        //Her bir karakterin silahı olur
        //Dövüşme tipi
        public int ID { get; set; }
        public string Skill {  get; set; }
        public List<Player> Player { get; set; }
    }
}
