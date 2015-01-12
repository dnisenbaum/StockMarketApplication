namespace StockMarketApplication
{
    partial class StockMarketDepthByOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMarketDepthByOrder));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuyVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyVolume,
            this.BuyPrice,
            this.SellPrice,
            this.SellVolume});
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // BuyVolume
            // 
            this.BuyVolume.DataPropertyName = "Name";
            this.BuyVolume.HeaderText = "Volume";
            this.BuyVolume.Name = "BuyVolume";
            // 
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "Price";
            this.BuyPrice.Name = "BuyPrice";
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Price";
            this.SellPrice.Name = "SellPrice";
            // 
            // SellVolume
            // 
            this.SellVolume.HeaderText = "Volume";
            this.SellVolume.Name = "SellVolume";
            // 
            // Sell
            // 
            this.Sell.AutoSize = true;
            this.Sell.Location = new System.Drawing.Point(325, 9);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(24, 13);
            this.Sell.TabIndex = 4;
            this.Sell.Text = "Sell";
            // 
            // Buy
            // 
            this.Buy.AutoSize = true;
            this.Buy.Location = new System.Drawing.Point(118, 9);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(25, 13);
            this.Buy.TabIndex = 3;
            this.Buy.Text = "Buy";
            // 
            // StockMarketDepthByOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 176);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockMarketDepthByOrder";
            this.Text = "Stock Market Depth By Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockMarketDepthByOrder_FormClosed);
            this.Load += new System.EventHandler(this.StockMarketDepthByOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Sell;
        private System.Windows.Forms.Label Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellVolume;
    }
}