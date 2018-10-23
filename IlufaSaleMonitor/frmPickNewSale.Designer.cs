namespace IlufaSaleMonitor
{
    partial class frmPickNewSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPickNewSale));
            this.bCancel = new System.Windows.Forms.Button();
            this.bPctDiscount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b_buy_x_for_rp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bFixedPrice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCancel.BackgroundImage")));
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancel.ForeColor = System.Drawing.Color.Transparent;
            this.bCancel.Location = new System.Drawing.Point(153, 151);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(64, 64);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bPctDiscount
            // 
            this.bPctDiscount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.bPctDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPctDiscount.BackgroundImage")));
            this.bPctDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPctDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bPctDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bPctDiscount.Location = new System.Drawing.Point(10, 12);
            this.bPctDiscount.Name = "bPctDiscount";
            this.bPctDiscount.Size = new System.Drawing.Size(100, 92);
            this.bPctDiscount.TabIndex = 3;
            this.bPctDiscount.UseVisualStyleBackColor = false;
            this.bPctDiscount.Click += new System.EventHandler(this.bPctDiscount_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(23, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Percent Discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_buy_x_for_rp
            // 
            this.b_buy_x_for_rp.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.b_buy_x_for_rp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_buy_x_for_rp.BackgroundImage")));
            this.b_buy_x_for_rp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_buy_x_for_rp.Location = new System.Drawing.Point(135, 12);
            this.b_buy_x_for_rp.Name = "b_buy_x_for_rp";
            this.b_buy_x_for_rp.Size = new System.Drawing.Size(100, 92);
            this.b_buy_x_for_rp.TabIndex = 7;
            this.b_buy_x_for_rp.UseVisualStyleBackColor = false;
            this.b_buy_x_for_rp.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(150, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buy X for Rp. ###";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bFixedPrice
            // 
            this.bFixedPrice.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.bFixedPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bFixedPrice.BackgroundImage")));
            this.bFixedPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFixedPrice.Location = new System.Drawing.Point(266, 12);
            this.bFixedPrice.Name = "bFixedPrice";
            this.bFixedPrice.Size = new System.Drawing.Size(100, 92);
            this.bFixedPrice.TabIndex = 9;
            this.bFixedPrice.UseVisualStyleBackColor = false;
            this.bFixedPrice.Click += new System.EventHandler(this.bFixedPrice_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(279, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fixed Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmPickNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 237);
            this.Controls.Add(this.bFixedPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_buy_x_for_rp);
            this.Controls.Add(this.bPctDiscount);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPickNewSale";
            this.Text = "Choose Sale Type";
            this.Load += new System.EventHandler(this.frmPickNewSale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bPctDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_buy_x_for_rp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bFixedPrice;
        private System.Windows.Forms.Label label4;
    }
}