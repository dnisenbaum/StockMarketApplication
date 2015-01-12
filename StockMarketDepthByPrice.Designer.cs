namespace StockMarketApplication
{
    partial class StockMarketDepthByPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMarketDepthByPrice));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyNum,
            this.BuyVolume,
            this.BuyPrice,
            this.SellPrice,
            this.SellVolume,
            this.SellNum});
            this.dataGridView1.Location = new System.Drawing.Point(1, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 147);
            this.dataGridView1.TabIndex = 1;
            // 
            // BuyNum
            // 
            this.BuyNum.HeaderText = "#";
            this.BuyNum.Name = "BuyNum";
            // 
            // BuyVolume
            // 
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
            // SellNum
            // 
            this.SellNum.HeaderText = "#";
            this.SellNum.Name = "SellNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buy";
            // 
            // StockMarketDepthByPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockMarketDepthByPrice";
            this.Text = "Stock Market Depth By Price";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockMarketDepthByPrice_FormClosed);
            this.Load += new System.EventHandler(this.StockMarketDepthByPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}