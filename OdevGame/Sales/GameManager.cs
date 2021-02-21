using OdevGame.Campaingn;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.Sales
{
    public class GameManager : IGameService,ICampaingnService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Kaydedildi: " + game.GameName);
        }

        public void ApplyTheCampaign(Campaingn.Campaingn campaingn)
        {
            Console.WriteLine("Kampanyalı Ürün");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi: " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi: " + game.GameName);
        }
    }
}
