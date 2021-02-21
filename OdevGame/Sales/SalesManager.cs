using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.Sales
{
    public class SalesManager : BaseOrderManager
    {
        private ISalesManager _salesManager;
        public SalesManager(ISalesManager salesManager)
        {
            _salesManager = salesManager;
        }
        public void Add( Order order)
        {
            if (_salesManager.Orders(order))
            {
                base.Add(order);
            }
            else
            {
                throw new Exception("Sipariş geçerli değil!");
            }
        }
    }
}
