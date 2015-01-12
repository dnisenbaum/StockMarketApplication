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
    public partial class StockMarketDepthByOrder : Form, StockMarketDisplay
    {
        RealTimeData data;
        Company company;

        public StockMarketDepthByOrder()
        {
            InitializeComponent();
        }

        //overloaded constructor
        public StockMarketDepthByOrder(string name, RealTimeData data)
        {
            InitializeComponent();
            this.data = data; //setting data variable
            //setting company variable when match is found
            foreach (Company company in data.companies)
            {
                if (company.getName() == name)
                    this.company = company;
            }
            Update(data); //updating observer with data
        }

        //when form loads
        private void StockMarketDepthByOrder_Load(object sender, EventArgs e)
        {
            data.Register(this); //register this observer
            Update(data); //update observer

            //dont allow user to add rows
            dataGridView1.AllowUserToAddRows = false;
        }

        public void Update(RealTimeData data)
        {
            dataGridView1.Rows.Clear(); //clear grid

            //set size of rows to add
            int size;
            if (company.getSellOrderSize() > company.getBuyOrderSize())
                size = company.getSellOrderSize();
            else
                size = company.getBuyOrderSize();

            //add row to data grid view
            for (int i = 0; i < size; i++)
            {
                //if no buy orders in row
                if (i >= company.getBuyOrderSize())
                {
                    dataGridView1.Rows.Add("", "", company.getSellOrder(i).getPrice(), 
                        company.getSellOrder(i).getVolume());
                }
                //if no sell orders in row
                else if (i >= company.getSellOrderSize())
                {
                    dataGridView1.Rows.Add(company.getBuyOrder(i).getVolume(), company.getBuyOrder(i).getPrice());
                }
                //if both sell and buy order in row
                else
                {
                    dataGridView1.Rows.Add(company.getBuyOrder(i).getVolume(), company.getBuyOrder(i).getPrice(),
                       company.getSellOrder(i).getPrice(), company.getSellOrder(i).getVolume());
                }
            }          
        }

        //when form closed
        private void StockMarketDepthByOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.unRegister(this); //unregister observer
        }
    }
}
