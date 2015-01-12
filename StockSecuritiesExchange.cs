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
    public partial class StockSecuritiesExchange : Form
    {
        RealTimeData data;

        public StockSecuritiesExchange()
        {
            InitializeComponent();
            //show check mark margin in windows menu
            ((ToolStripDropDownMenu)windowsToolStripMenuItem.DropDown).ShowCheckMargin = true;

            stopTradingToolStripMenuItem.Enabled = false; //disable stop trading menu item
            ordersToolStripMenuItem.Visible = false; //disable order menu item
            watchToolStripMenuItem.Visible = false; //disable watch menu item
            data = new RealTimeData(); //initialize data
        }

        //click on cascade
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //click on horizontal tile
        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //click on vertical tile
        private void verticalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //event when you click exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //click on being trading
        private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marketToolStripMenuItem.Text = "Market <<Open>>"; //change title
            stopTradingToolStripMenuItem.Enabled = true; //enable stop trading
            beginTradingToolStripMenuItem.Enabled = false; //disable being trading
            ordersToolStripMenuItem.Visible = true; //enable orders
            watchToolStripMenuItem.Visible = true; //enable watch
        }

        //click on bid
        private void placeBidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceBid newBidForm = new PlaceBid(data); //new place bid form passing data
            newBidForm.MdiParent = this; // Set the parent form of the child window. 
            newBidForm.Show(); // Display the new form.
        }

        //click on ask
        private void askToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceSell newBidForm = new PlaceSell(data); //new place sell form passing data 
            newBidForm.MdiParent = this; // Set the parent form of the child window.
            newBidForm.Show(); // Display the new form.
        }
        
        //click on stock state summary
        private void stockStateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new stock state summary form passing data 
            StockStateSummary newStockMarketForm = new StockStateSummary(data);
            newStockMarketForm.MdiParent = this; // Set the parent form of the child window
            newStockMarketForm.Show(); // Display the new form.
        }

        //click on stock market depth by order
        private void stockMarketDepthByOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender; //retrieve item that called this function
            //create observer passing data and name of company
            Debug.WriteLine(Text);
            StockMarketDepthByOrder newStockMarketForm = new StockMarketDepthByOrder(item.Text, data);

            newStockMarketForm.MdiParent = this; //set parent of child window
            newStockMarketForm.Text = newStockMarketForm.Text + " (" + item.Text + ")"; //change text
            newStockMarketForm.Show(); //show new form
        }

        //click on stock market depth by price
        private void stockMarketDepthByPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender; //retrieve item that called this function
            //create observer passing data and name of company
            StockMarketDepthByPrice newStockMarketForm = new StockMarketDepthByPrice(item.Text, data);

            newStockMarketForm.MdiParent = this; //set parent of child window
            newStockMarketForm.Text = newStockMarketForm.Text + " (" + item.Text + ")"; //change title of window
            newStockMarketForm.Show(); //show new form
        }

        //on load of client
        private void StockSecuritiesExchange_Load(object sender, EventArgs e)
        {
            //create arrays of items in stock market by depth and stock market by price
            ToolStripMenuItem[] orderItem = new ToolStripMenuItem[3];
            ToolStripMenuItem[] priceItem = new ToolStripMenuItem[3];
            int i = 0; //counter

            foreach (Company company in data.companies)
            {
                orderItem[i] = new ToolStripMenuItem(company.getName()); //set item in stock market by depth menu
                priceItem[i] = new ToolStripMenuItem(company.getName()); //set item in stock market by price menu
                marketDepthByOrderToolStripMenuItem.DropDownItems.Add(orderItem[i]); //add item to menu
                marketDepthByPriceToolStripMenuItem.DropDownItems.Add(priceItem[i]); //add item to menu
                //create event handlers for each item
                orderItem[i].Click += new System.EventHandler(this.stockMarketDepthByOrderToolStripMenuItem_Click);
                priceItem[i].Click += new System.EventHandler(this.stockMarketDepthByPriceToolStripMenuItem_Click);
                i++; //increment array counter
            }
        }

        //click on stop trading
        private void stopTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //close form
        }
    }
}
