using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Diagnostics;

namespace StockMarketApplication
{
    public class Company
    {
        //company variables
        string companyName;
        string companySymbol;
        double openPrice;
        double lastPrice;
        double netChange;
        Image image;
        double changePercentage;
        int shareVolume;

        List<BuyOrder> buyOrders = new List<BuyOrder>(); //list of buy orders
        List<SellOrder> sellOrders = new List<SellOrder>(); //list of sell orders
        List<Order> transactions = new List<Order>(); //list of transactions

        //overloaded constructor
        public Company(string name, string symbol, double price)
        {
            companyName = name;
            companySymbol = symbol;
            openPrice = price;
            lastPrice = 0;
            netChange = 0;
            setImage("noChange");
            changePercentage = 0;
            shareVolume = 0;
        }

//------------------------------Getting Company Info and Setting Company variables----------------------

        public string getName()
        {
            return companyName;
        }

        public string getSymbol()
        {
            return companySymbol;
        }

        public double getOpenPrice()
        {
            return openPrice;
        }

        public double getLastPrice()
        {
            return lastPrice;
        }

        public double getNetChange()
        {
            return netChange;
        }

        public Image getImage()
        {
            return image;
        }

        public double getChangePercentage()
        {
            return changePercentage;
        }

        public int getShareVolume()
        {
            return shareVolume;
        }

        public void setLastPrice(double price)
        {
            lastPrice = price;
        }

        public void setImage(string name)
        {
            Image noChange = Image.FromFile("noChange.bmp");
            Image up = Image.FromFile("up.bmp");
            Image down = Image.FromFile("down.bmp");

            if (name == "noChange")
                image = noChange;
            else if (name == "up")
                image = up;
            else
                image = down;
        }

//-------------------------------------------Buy Orders Methods-------------------------------------

        //add buy order
        public void addBuyOrder(BuyOrder order)
        {
            buyOrders.Add(order);//add buy order
            buyOrders = buyOrders.OrderByDescending(x => x.getPrice()).ToList();//sort buy order by highest price

            transactionCheck(order, "buy");//check for transactions
        }
        //get specific buy order
        public BuyOrder getBuyOrder(int index)
        {
            return buyOrders[index];
        }
        //get buy orde size
        public int getBuyOrderSize()
        {
            return buyOrders.Count;
        }

        //get all buy orders
        public List<BuyOrder> getBuyOrders()
        {
            return buyOrders;
        }


//----------------------------------------Sell Orders Methods--------------------------------------

        //add sell order
        public void addSellOrder(SellOrder order)
        {
            sellOrders.Add(order); //add sell order
            sellOrders = sellOrders.OrderBy(x => x.getPrice()).ToList(); //sort orders

            transactionCheck(order, "sell"); //check transactions
        }
        //get specific sell order
        public SellOrder getSellOrder(int index)
        {
            return sellOrders[index];
        }
        //get size of sell order
        public int getSellOrderSize()
        {
            return sellOrders.Count;
        }

        //get all sell orders
        public List<SellOrder> getSellOrders()
        {
            return sellOrders;
        }

//------------------------------------------Transactions and Update methods-----------------------------

        //check for potential buyers/sellers
        public void transactionCheck(Order ord, string type)
        {
            Order order = ord; //set incoming variables

            //if making a buy transaction
            if (type == "buy")
            {
                order = (BuyOrder)ord; //set order to a buy order

                //find seller
                foreach (Order o in sellOrders)
                {
                    //if we find a price in sellOrders that matches or less than buying price
                    if (o.getPrice() <= order.getPrice())
                    {
                        //if more shares in seller
                        if (o.getVolume() > order.getVolume())
                        {
                            this.shareVolume += order.getVolume(); //adding share volumes
                            o.setVolume(o.getVolume() - order.getVolume()); //set new buy order price
                            UpdateCompany(o, type); //update company info
                            transactions.Add(order); //add buy order to transactions list
                            break; //exit loop
                        }
                        //if more shares in buyer
                        else if (o.getVolume() < order.getVolume())
                        {
                            this.shareVolume += o.getVolume(); //adding share volumes
                            order.setVolume(order.getVolume() - o.getVolume()); //set new sell order price
                            UpdateCompany(o, type); //update company info
                            transactions.Add(o); // add to sell order to transactions list
                            //keep searching
                        }
                        //if equal amount of shares
                        else
                        {
                            this.shareVolume += order.getVolume(); //adding share volumes
                            UpdateCompany(order, type); //update company info
                            transactions.Add(o); //add sell order to transactions list
                            transactions.Add(order); //add buy order to transactions list
                            break; //exit loop
                        }
                        
                    }
                }

                
            }
            else
            {
                order = (SellOrder)ord; //set order to sell order
                
                //find buyer
                foreach (Order o in buyOrders)
                {
                    //if we found a price in buyOrders that matches or more than selling price
                    if (o.getPrice() >= order.getPrice())
                    {
                        //if more shares in buyer
                        if (o.getVolume() > order.getVolume())
                        {
                            this.shareVolume += order.getVolume(); //adding share volumes
                            o.setVolume(o.getVolume() - order.getVolume()); //set new buy order price
                            UpdateCompany(order, type); //update company info
                            transactions.Add(order); //add sell order to transactions list
                            break; //exit loop
                        }
                        //if more shares in seller
                        else if (o.getVolume() < order.getVolume())
                        {
                            this.shareVolume += o.getVolume(); //adding share volumes
                            order.setVolume(order.getVolume() - o.getVolume()); //set new sell order price
                            UpdateCompany(o, type); //update company info
                            transactions.Add(o); //add buy order to transactions list
                            //keep searching
                        }
                        //if equal amount of shares
                        else
                        {
                            this.shareVolume += order.getVolume(); //adding share volumes
                            UpdateCompany(order, type); //update company info
                            transactions.Add(o); //add buy order to transactions list
                            transactions.Add(order); //add sell order to transactions list
                            break; //exit loop
                        }
                        
                    }
                }
            }

            //removing pending orders since they have been matched
            foreach (Order temp in transactions)
            {
                SellOrder dummy = new SellOrder();
                if (temp.GetType().Equals(dummy.GetType()))
                    sellOrders.Remove((SellOrder)temp);
                else
                    buyOrders.Remove((BuyOrder)temp);
            }
        }

        //updating company variables
        public void UpdateCompany(Order ord, string type)
        {
            Order order = ord; //setting incoming variable
			this.netChange = Math.Abs(openPrice - order.getPrice()); //calculating net change
			this.changePercentage = Math.Round(netChange / openPrice * 100, 2); //calcualting net percentage
			this.lastPrice = order.getPrice(); //setting last price
            //deciding which image to display
			if (openPrice < lastPrice)
				this.setImage("up");
			else if (openPrice > lastPrice)
				this.setImage("down");
			else
				this.setImage("noChange");
        }
    }
}
