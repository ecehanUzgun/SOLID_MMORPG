using DataAccess.Context;
using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories.Concretes
{
    public class PlayerRepository:PlayerBaseRepository
    {
        //Create Player: Oyuncu bilgileri için nesnenin örneğini ram üzerine alacak ve bu örneği döndürecek.
        private readonly MmorpgContext db = new MmorpgContext();

        public override Player CreatePlayer()
        {
            return new Player();
        }
        public override Player GetPlayer(int playerId)
        {
            return db.Players.Find(playerId);
            //Eğer bu arama işleminin sonucunda playerId bulunmaz ise geriye null döner. Bu da bize "null references exception" olarak runtime'da sıkıntı çıkarır.
        }

        public override string SavePlayerDatabase(Player player)
        {
            try
            {
                db.Players.Add(player);
                db.SaveChanges();
                return $"{player.PlayerName} veritabanına kaydedildi.";
            }
            catch(Exception ex)
            { 
                return ex.Message;
            }
        }
    }
}
