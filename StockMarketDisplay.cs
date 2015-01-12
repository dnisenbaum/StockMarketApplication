using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketApplication
{
    public interface StockMarketDisplay
    {
        void Update(RealTimeData data);
    }
}