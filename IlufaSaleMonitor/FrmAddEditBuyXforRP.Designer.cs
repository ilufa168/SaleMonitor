namespace IlufaSaleMonitor
{
    partial class FrmAddEditBuyXforRP
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
            this.lblItems = new System.Windows.Forms.Label();
            this.nNumItems = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscPct)).BeginInit();
            this.pPercentDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(574, 57);
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.Text = "Combined Amt (Rp.)";
            // 
            // nbDiscPct
            // 
            this.nbDiscPct.DecimalPlaces = 0;
            this.nbDiscPct.Location = new System.Drawing.Point(571, 77);
            this.nbDiscPct.ValueChanged += new System.EventHandler(this.nbDiscPct_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.Visible = false;
            // 
            // tbItemCodes
            // 
            this.tbItemCodes.Enabled = false;
            this.tbItemCodes.Visible = false;
            // 
            // label8
            // 
            this.label8.Visible = false;
            // 
            // pPercentDiscount
            // 
            this.pPercentDiscount.Controls.Add(this.nNumItems);
            this.pPercentDiscount.Controls.Add(this.lblItems);
            this.pPercentDiscount.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.dtpEndDate, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.tvAll, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.lblItems, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.panel1, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.label4, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.nbDiscPct, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.label7, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.tbItemCodes, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.label8, 0);
            this.pPercentDiscount.Controls.SetChildIndex(this.nNumItems, 0);
            // 
            // tvAll
            // 
            this.tvAll.LineColor = System.Drawing.Color.Black;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged_1);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged_1);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.Color.Blue;
            this.lblItems.Location = new System.Drawing.Point(470, 57);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(53, 16);
            this.lblItems.TabIndex = 27;
            this.lblItems.Text = "# Items";
            // 
            // nNumItems
            // 
            this.nNumItems.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNumItems.Location = new System.Drawing.Point(463, 77);
            this.nNumItems.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nNumItems.Name = "nNumItems";
            this.nNumItems.Size = new System.Drawing.Size(67, 22);
            this.nNumItems.TabIndex = 28;
            this.nNumItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nNumItems.ValueChanged += new System.EventHandler(this.nNumItems_ValueChanged);
            // 
            // FrmAddEditBuyXforRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1164, 726);
            this.Name = "FrmAddEditBuyXforRP";
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscPct)).EndInit();
            this.pPercentDiscount.ResumeLayout(false);
            this.pPercentDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblItems;
        protected System.Windows.Forms.NumericUpDown nNumItems;
    }
}
