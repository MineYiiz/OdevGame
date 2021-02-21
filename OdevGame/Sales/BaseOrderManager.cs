using OdevGame.Campaingn;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.Sales
{
    public class BaseOrderManager : IGameService, IOrderService,ICampaingnService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Kaydedildi: "+ game.GameName);
        }

        public void ConfirmOrder(Order order)
        {
            Console.WriteLine("Siparişiniz Onaylandı");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi: " + game.GameName);
        }

        internal void Add(Order order)
        {
            Console.WriteLine("Sipariş Kaydedildi: " + order.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi: " + game.GameName);
        }

        public void ApplyTheCampaign(Campaingn.Campaingn campaingn)
        {
            Console.WriteLine("Kampanyalı Ürün");
        }
    }
}
