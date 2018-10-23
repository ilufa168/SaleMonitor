namespace IlufaSaleMonitor
{
    partial class frmAddEditSale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditSale));
            this.cbSaleType = new System.Windows.Forms.ComboBox();
            this.pPercentDiscount = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbItemCodes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bAddSupplier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbCurrentItems = new System.Windows.Forms.RichTextBox();
            this.tbSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nbDiscPct = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaleId = new System.Windows.Forms.Label();
            this.tvAll = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBuyXGetY = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pPercentDiscount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscPct)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSaleType
            // 
            this.cbSaleType.FormattingEnabled = true;
            this.cbSaleType.Items.AddRange(new object[] {
            "% Discount",
            "Fixed Amount Sale"});
            this.cbSaleType.Location = new System.Drawing.Point(26, 26);
            this.cbSaleType.Name = "cbSaleType";
            this.cbSaleType.Size = new System.Drawing.Size(161, 22);
            this.cbSaleType.TabIndex = 0;
            this.cbSaleType.SelectedIndexChanged += new System.EventHandler(this.cbSaleType_SelectedIndexChanged);
            // 
            // pPercentDiscount
            // 
            this.pPercentDiscount.BackColor = System.Drawing.Color.Tan;
            this.pPercentDiscount.Controls.Add(this.dtpEndDate);
            this.pPercentDiscount.Controls.Add(this.dtpStartDate);
            this.pPercentDiscount.Controls.Add(this.label8);
            this.pPercentDiscount.Controls.Add(this.tbItemCodes);
            this.pPercentDiscount.Controls.Add(this.label7);
            this.pPercentDiscount.Controls.Add(this.button1);
            this.pPercentDiscount.Controls.Add(this.bAddSupplier);
            this.pPercentDiscount.Controls.Add(this.groupBox1);
            this.pPercentDiscount.Controls.Add(this.tbSupplier);
            this.pPercentDiscount.Controls.Add(this.label6);
            this.pPercentDiscount.Controls.Add(this.label5);
            this.pPercentDiscount.Controls.Add(this.nbDiscPct);
            this.pPercentDiscount.Controls.Add(this.label4);
            this.pPercentDiscount.Controls.Add(this.label3);
            this.pPercentDiscount.Controls.Add(this.label2);
            this.pPercentDiscount.Controls.Add(this.lblSaleId);
            this.pPercentDiscount.Controls.Add(this.tvAll);
            this.pPercentDiscount.Controls.Add(this.label1);
            this.pPercentDiscount.Controls.Add(this.panel1);
            this.pPercentDiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPercentDiscount.Location = new System.Drawing.Point(26, 54);
            this.pPercentDiscount.Name = "pPercentDiscount";
            this.pPercentDiscount.Size = new System.Drawing.Size(1065, 660);
            this.pPercentDiscount.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(438, 240);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(279, 22);
            this.dtpEndDate.TabIndex = 24;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(438, 157);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(279, 22);
            this.dtpStartDate.TabIndex = 23;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(845, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Item Codes:";
            // 
            // tbItemCodes
            // 
            this.tbItemCodes.Location = new System.Drawing.Point(794, 181);
            this.tbItemCodes.Name = "tbItemCodes";
            this.tbItemCodes.Size = new System.Drawing.Size(184, 22);
            this.tbItemCodes.TabIndex = 20;
            this.tbItemCodes.TextChanged += new System.EventHandler(this.tbItemCodes_TextChanged);
            this.tbItemCodes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbItemCodes_KeyDown);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(757, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 68);
            this.label7.TabIndex = 19;
            this.label7.Text = "Manual item entries:  Enter in comma seperated item codes for a supplier already " +
    "included in the sale.  These items will be selected as sale items.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(112, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bAddSupplier
            // 
            this.bAddSupplier.BackColor = System.Drawing.Color.LightBlue;
            this.bAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddSupplier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddSupplier.ForeColor = System.Drawing.Color.Blue;
            this.bAddSupplier.Location = new System.Drawing.Point(968, 41);
            this.bAddSupplier.Name = "bAddSupplier";
            this.bAddSupplier.Size = new System.Drawing.Size(40, 33);
            this.bAddSupplier.TabIndex = 17;
            this.bAddSupplier.Text = "Add";
            this.bAddSupplier.UseVisualStyleBackColor = false;
            this.bAddSupplier.Click += new System.EventHandler(this.bAddSupplier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbCurrentItems);
            this.groupBox1.Location = new System.Drawing.Point(738, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 404);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Items";
            // 
            // rtbCurrentItems
            // 
            this.rtbCurrentItems.BackColor = System.Drawing.Color.Tan;
            this.rtbCurrentItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCurrentItems.Location = new System.Drawing.Point(6, 22);
            this.rtbCurrentItems.Name = "rtbCurrentItems";
            this.rtbCurrentItems.ReadOnly = true;
            this.rtbCurrentItems.Size = new System.Drawing.Size(285, 375);
            this.rtbCurrentItems.TabIndex = 0;
            this.rtbCurrentItems.Text = "";
            // 
            // tbSupplier
            // 
            this.tbSupplier.Location = new System.Drawing.Point(776, 57);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(184, 22);
            this.tbSupplier.TabIndex = 15;
            this.tbSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSupplier_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(798, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Add Supplier to Sale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Items for Sale";
            // 
            // nbDiscPct
            // 
            this.nbDiscPct.DecimalPlaces = 4;
            this.nbDiscPct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbDiscPct.Location = new System.Drawing.Point(516, 63);
            this.nbDiscPct.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbDiscPct.Name = "nbDiscPct";
            this.nbDiscPct.Size = new System.Drawing.Size(140, 22);
            this.nbDiscPct.TabIndex = 12;
            this.nbDiscPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbDiscPct.ValueChanged += new System.EventHandler(this.nbDiscPct_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(548, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Discount %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(438, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sale Stop Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(438, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sale Start Date";
            // 
            // lblSaleId
            // 
            this.lblSaleId.AutoSize = true;
            this.lblSaleId.Location = new System.Drawing.Point(64, 11);
            this.lblSaleId.Name = "lblSaleId";
            this.lblSaleId.Size = new System.Drawing.Size(42, 16);
            this.lblSaleId.TabIndex = 3;
            this.lblSaleId.Text = "label2";
            // 
            // tvAll
            // 
            this.tvAll.CheckBoxes = true;
            this.tvAll.ImageKey = "uncheck.bmp";
            this.tvAll.Location = new System.Drawing.Point(18, 57);
            this.tvAll.Name = "tvAll";
            this.tvAll.Size = new System.Drawing.Size(393, 559);
            this.tvAll.TabIndex = 2;
            this.tvAll.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvAll_BeforeCheck);
            this.tvAll.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvAll_AfterCheck);
            this.tvAll.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvAll_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale ID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(738, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 112);
            this.panel1.TabIndex = 22;
            // 
            // pBuyXGetY
            // 
            this.pBuyXGetY.BackColor = System.Drawing.Color.Bisque;
            this.pBuyXGetY.Location = new System.Drawing.Point(450, 92);
            this.pBuyXGetY.Name = "pBuyXGetY";
            this.pBuyXGetY.Size = new System.Drawing.Size(587, 463);
            this.pBuyXGetY.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "uncheck.bmp");
            this.imageList1.Images.SetKeyName(1, "check.bmp");
            this.imageList1.Images.SetKeyName(2, "unknown.bmp");
            // 
            // frmAddEditSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1164, 726);
            this.Controls.Add(this.pPercentDiscount);
            this.Controls.Add(this.cbSaleType);
            this.Controls.Add(this.pBuyXGetY);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddEditSale";
            this.Text = "Add/Edit Sale";
            this.Load += new System.EventHandler(this.frmAddEditSale_Load);
            this.pPercentDiscount.ResumeLayout(false);
            this.pPercentDiscount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscPct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSaleType;
        private System.Windows.Forms.Panel pPercentDiscount;
        private System.Windows.Forms.Panel pBuyXGetY;
        private System.Windows.Forms.Label lblSaleId;
        private System.Windows.Forms.TreeView tvAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bAddSupplier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbItemCodes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.NumericUpDown nbDiscPct;
        internal System.Windows.Forms.RichTextBox rtbCurrentItems;
    }
}