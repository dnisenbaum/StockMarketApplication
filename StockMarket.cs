using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketApplication
{
    public interface StockMarket
    {
        void Register(StockMarketDisplay observer);
        void unRegister(StockMarketDisplay observer);
        void Notify();
    }
}
