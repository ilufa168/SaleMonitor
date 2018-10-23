namespace IlufaSaleMonitor
{
    partial class frmAddEditFixedAmount
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
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscPct)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(160, 11);
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.Text = "Discount Amount (Rp.)";
            // 
            // nbDiscPct
            // 
            this.nbDiscPct.DecimalPlaces = 0;
            this.nbDiscPct.ValueChanged += new System.EventHandler(this.nbDiscPct_ValueChanged);
            // 
            // frmAddEditFixedAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1112, 726);
            this.Name = "frmAddEditFixedAmount";
            this.Text = "Add/Edit Fixed Amount Sale";
            this.Load += new System.EventHandler(this.frmAddEditFixedAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscPct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
