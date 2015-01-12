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
    public partial class PlaceBid : Form
    {
        RealTimeData data;

        public PlaceBid()
        {
            InitializeComponent();
        }

        public PlaceBid(RealTimeData data)
        {
            InitializeComponent();
            //initializing combo box items
            foreach (Company company in data.companies)
            {
                comboBox1.Items.Add(company.getName());
            }
            this.data = data; //setting data variable
        }

        //click submit
        private void submitButton_Click(object sender, EventArgs e)
        {
            //getting values from form
            int index = comboBox1.SelectedIndex; //index of company
            try
            {
                int volume = Convert.ToInt32(textBox1.Text); //number of shares entered
                double price = Convert.ToDouble(textBox2.Text); //price entered

                //throw exception if volume or price are less than or equal to 0
                if (volume <= 0 || price <= 0)
                {
                    throw new Exception();
                }

                BuyOrder order = new BuyOrder(price, volume); //create a buy order form
                data.companies[index].addBuyOrder(order); //add this buy order to the relative company
                data.Notify(); //notify observers
                this.Close(); //close form
            }
            catch 
            {
                //clear both text boxes when there is an error in input type
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        //click cancel
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close form
        }

        private void PlaceBid_Load(object sender, EventArgs e)
        {
            //set default drop down to first item
            comboBox1.SelectedIndex = 0;
        }
    }
}
