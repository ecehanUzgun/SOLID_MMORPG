using DataAccess.Entities;

namespace DataAccess.Repositories.Abstracts
{
    public abstract class PlayerBaseRepository
    {
        //CreatePlayer: Oyuncu bilgileri için nesnenin örneğini ram üzerine alacak ve bu örneği döndürecek.
        public abstract Player CreatePlayer();

        //SavePlayerDatabase: Yukarıda alınan örneğin veritabanına kaydını gerçekleştirecek.
        public abstract string SavePlayerDatabase(Player player);

        //GetPlayer: Kaydı gerçekleştirilen oyuncunun bilgilerini getirecek.
        public abstract Player GetPlayer(int playerId);
    }   
}
