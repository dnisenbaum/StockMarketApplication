using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace StockMarketApplication
{
    public class RealTimeData : StockMarket
    {
        public List<Company> companies = new List<Company>(); //list of companies
        public List<StockMarketDisplay> observers = new List<StockMarketDisplay>(); //list of observers
        
        public RealTimeData()
        {
            //adding companies
            companies.Add(new Company("Microsoft Corporation", "MSFT", 46.13));
            companies.Add(new Company("Apple Inc", "APPL", 105.22));
            companies.Add(new Company("Facebook, Inc", "FB", 80.67));;
        }

        public void Register(StockMarketDisplay observer)
        {
            //add observer when it registers
            observers.Add(observer);
        }
        public void unRegister(StockMarketDisplay observer)
        {
            //remove observer when it unregisters
            observers.Remove(observer);
        }
        public void Notify()
        {
            //notify each observer
            foreach (StockMarketDisplay observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
