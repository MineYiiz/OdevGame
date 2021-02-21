using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.Sales
{
    public class OrderManager : IOrderService 
    {
        public void ConfirmOrder(Order order)
        {
            Console.WriteLine("Siparişiniz Onaylandı");
        }
    }
}
