namespace StockMarketApplication
{
    partial class StockStateSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockStateSummary));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrows = new System.Windows.Forms.DataGridViewImageColumn();
            this.ChangePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company,
            this.Symbol,
            this.Price,
            this.LastSale,
            this.ChangeNet,
            this.arrows,
            this.ChangePercent,
            this.Shares});
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 147);
            this.dataGridView1.TabIndex = 1;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 120;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Price
            // 
            this.Price.HeaderText = "Open Price";
            this.Price.Name = "Price";
            // 
            // LastSale
            // 
            this.LastSale.HeaderText = "Last Sale";
            this.LastSale.Name = "LastSale";
            // 
            // ChangeNet
            // 
            this.ChangeNet.HeaderText = "Change Net";
            this.ChangeNet.Name = "ChangeNet";
            // 
            // arrows
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.arrows.DefaultCellStyle = dataGridViewCellStyle1;
            this.arrows.HeaderText = "";
            this.arrows.Name = "arrows";
            this.arrows.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arrows.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.arrows.Width = 30;
            // 
            // ChangePercent
            // 
            this.ChangePercent.HeaderText = "Change %";
            this.ChangePercent.Name = "ChangePercent";
            // 
            // Shares
            // 
            this.Shares.HeaderText = "Share Volume";
            this.Shares.Name = "Shares";
            // 
            // StockStateSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 150);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockStateSummary";
            this.Text = "Stock State Summary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockStateSummary_FormClosed);
            this.Load += new System.EventHandler(this.StockStateSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeNet;
        private System.Windows.Forms.DataGridViewImageColumn arrows;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shares;
    }
}