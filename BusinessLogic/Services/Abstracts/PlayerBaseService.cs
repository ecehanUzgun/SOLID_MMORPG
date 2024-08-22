using DataAccess.Entities;

namespace BusinessLogic.Services.Abstracts
{
    public abstract class PlayerBaseService
    {
        public abstract Player CreatePlayer();
        public abstract Player GetPlayer(int playerId); 
        public abstract string SavePlayer(Player player);
        //Game Methods
        
    }
}
