using BusinessLogic.Services.Abstracts;
using DataAccess.Entities;
using DataAccess.Repositories.Concretes;

namespace BusinessLogic.Services.Concretes
{
    public class PlayerService : PlayerBaseService
    {
        PlayerRepository playerRepository = new PlayerRepository();

        public override Player CreatePlayer()
        {
            return playerRepository.CreatePlayer();
        }

        public override Player GetPlayer(int playerId)
        {
            return playerRepository.GetPlayer(playerId);
        }

        public override string SavePlayer(Player player)
        {
            return playerRepository.SavePlayerDatabase(player);
        }
    }
}
