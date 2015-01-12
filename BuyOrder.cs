using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketApplication
{
    public class BuyOrder : Order
    {
        string orderDate; //date of order -> not used
        int orderSize; //size/volume of order
        double orderPrice; //price of order

        //defualt constructor
        public BuyOrder()
        {
        }

        //overloaded constructor
        public BuyOrder(double price, int size)
        {
            orderPrice = price;
            orderSize = size;
        }

        //get price of order
        public double getPrice()
        {
            return orderPrice;
        }

        //get volume of order
        public int getVolume()
        {
            return orderSize;
        }

        //set price of order
        public void setPrice(double price)
        {
            orderPrice = price;
        }

        //set volume of order
        public void setVolume(int volume)
        {
            orderSize = volume;
        }
    }
}