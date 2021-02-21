using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.Sales
{
    public interface ISalesManager
    {
        public bool Orders(Order order);
    }
}
