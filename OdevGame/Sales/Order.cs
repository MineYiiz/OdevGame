using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.Sales
{
    public class Order
    {
        public int OrderId { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
