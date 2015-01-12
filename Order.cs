using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketApplication
{
    public interface Order
    {
        double getPrice();
        int getVolume();
        void setPrice(double price);
        void setVolume(int volume);
    }
}
