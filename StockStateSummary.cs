using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockMarketApplication
{
    public partial class StockStateSummary : Form, StockMarketDisplay
    {
        RealTimeData data;

        public StockStateSummary()
        {
            InitializeComponent();
        }

        //initlize this with data
        public StockStateSummary(RealTimeData data)
        {
            InitializeComponent();
            this.data = data; //setting data variable
        }

        private void StockStateSummary_Load(object sender, EventArgs e)
        {
            data.Register(this); //register this observer
            Update(data); //update observer

            //dont allow user to add rows
            dataGridView1.AllowUserToAddRows = false;
        }
        public void Update(RealTimeData data)
        {
            //clear grid
            dataGridView1.Rows.Clear();

            //add company info
            foreach (Company company in data.companies)
            {
                dataGridView1.Rows.Add(company.getName(), company.getSymbol(), company.getOpenPrice(), company.getLastPrice(), 
                    company.getNetChange(), company.getImage(), company.getChangePercentage(), company.getShareVolume());
            }
        }

        //close form
        private void StockStateSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.unRegister(this); //unregister observer
        }
    }
}
