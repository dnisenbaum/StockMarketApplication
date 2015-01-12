using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace StockMarketApplication
{
    public partial class StockMarketDepthByPrice : Form, StockMarketDisplay
    {
        RealTimeData data;
        Company company;

        public StockMarketDepthByPrice()
        {
            InitializeComponent();
        }

        //overloaded constructor
        public StockMarketDepthByPrice(string name, RealTimeData data)
        {
            InitializeComponent();
            this.data = data; //setting data variable
            //setting company variable when match is found
            foreach (Company company in data.companies)
            {
                if (company.getName() == name)
                    this.company = company;
            }
            Update(data); //update observer
        }

        //when form loads
        private void StockMarketDepthByPrice_Load(object sender, EventArgs e)
        {
            data.Register(this); //register his observer
            Update(data); //update observer

            //dont allow user to add rows
            dataGridView1.AllowUserToAddRows = false;
        }
        public void Update(RealTimeData data)
        {
            dataGridView1.Rows.Clear(); //clear grid

            List<BuyOrder> tmp = company.getBuyOrders(); //create temporary list of all buy orders
            var grpBuyOrders = tmp.GroupBy(x => x.getPrice()); //group list by price
            List<SellOrder> tmp2 = company.getSellOrders(); //create temporary list of sell orders
            var grpSellOrders = tmp2.GroupBy(x => x.getPrice()); //group list by price

            //find size to iterate rows on grid view
            int size = 0;
            if (company.getBuyOrderSize() > company.getSellOrderSize())
                size = company.getBuyOrderSize();
            else
                size = company.getSellOrderSize();

            //find volumes and sizes of orders and draw them
            for (int i = 0; i < size; i++)
            {
                //add up volume and size of order for all buy order groups
                int buyVolume = 0;
                int buyCounter = 0;
                double buyPrice = 0;
                if (i < grpBuyOrders.Count())
                {
                    buyPrice = grpBuyOrders.ElementAt(i).Key;
                    foreach (var value in grpBuyOrders.ElementAt(i))
                    {
                        buyVolume += value.getVolume();
                        buyCounter++;
                    }
                }
                //add up volume and size of order for all sell order groups
                int sellVolume = 0;
                int sellCounter = 0;
                double sellPrice = 0;
                if (i < grpSellOrders.Count())
                {
                    sellPrice = grpSellOrders.ElementAt(i).Key;
                    foreach (var value in grpSellOrders.ElementAt(i))
                    {
                        sellVolume += value.getVolume();
                        sellCounter++;
                    }
                }

                //if no buy orders in row
                if (i >= grpBuyOrders.Count())
                {
                    if (sellCounter > 0)
                    {
                        dataGridView1.Rows.Add("", "", "", sellPrice,
                            sellVolume, sellCounter);
                    }
                }
                //if no sell orders in row
                else if (i >= grpSellOrders.Count())
                {
                    if (buyCounter > 0)
                    {
                        dataGridView1.Rows.Add(buyCounter, buyVolume, buyPrice);
                    }
                }
                //if both buy and sell orders in row
                else
                {
                    if (buyCounter > 0 && sellCounter > 0)
                    {
                        dataGridView1.Rows.Add(buyCounter, buyVolume, buyPrice,
                            sellPrice, sellVolume, sellCounter);
                    }
                }
                
            }
        }

        private void StockMarketDepthByPrice_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.unRegister(this); //unregister observer
        }
    }
}
