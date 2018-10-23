namespace IlufaSaleMonitor
{
    partial class frmNewBuyXGetYFree
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
            this.label1 = new System.Windows.Forms.Label();
            this.snbX = new clSmartNumberBox.smarttNumberBox();
            this.snbY = new clSmartNumberBox.smarttNumberBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pCalendar = new System.Windows.Forms.Panel();
            this.lblSaleEnd = new System.Windows.Forms.Label();
            this.monthEnd = new System.Windows.Forms.MonthCalendar();
            this.lblSaleStart = new System.Windows.Forms.Label();
            this.monthStart = new System.Windows.Forms.MonthCalendar();
            this.cbYItems = new System.Windows.Forms.ComboBox();
            this.cbXItems = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.snbDiscount = new clSmartNumberBox.smarttNumberBox();
            this.bSave = new System.Windows.Forms.Button();
            this.pCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy X";
            // 
            // snbX
            // 
            this.snbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snbX.Location = new System.Drawing.Point(110, 23);
            this.snbX.Name = "snbX";
            this.snbX.Size = new System.Drawing.Size(55, 29);
            this.snbX.TabIndex = 1;
            // 
            // snbY
            // 
            this.snbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snbY.Location = new System.Drawing.Point(319, 23);
            this.snbY.Name = "snbY";
            this.snbY.Size = new System.Drawing.Size(66, 29);
            this.snbY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Get Y Disc";
            // 
            // pCalendar
            // 
            this.pCalendar.Controls.Add(this.lblSaleEnd);
            this.pCalendar.Controls.Add(this.monthEnd);
            this.pCalendar.Controls.Add(this.lblSaleStart);
            this.pCalendar.Controls.Add(this.monthStart);
            this.pCalendar.Location = new System.Drawing.Point(458, 12);
            this.pCalendar.Name = "pCalendar";
            this.pCalendar.Size = new System.Drawing.Size(259, 380);
            this.pCalendar.TabIndex = 9;
            // 
            // lblSaleEnd
            // 
            this.lblSaleEnd.AutoSize = true;
            this.lblSaleEnd.Location = new System.Drawing.Point(20, 198);
            this.lblSaleEnd.Name = "lblSaleEnd";
            this.lblSaleEnd.Size = new System.Drawing.Size(76, 13);
            this.lblSaleEnd.TabIndex = 10;
            this.lblSaleEnd.Text = "Sale End Date";
            // 
            // monthEnd
            // 
            this.monthEnd.Location = new System.Drawing.Point(20, 211);
            this.monthEnd.MaxSelectionCount = 1;
            this.monthEnd.Name = "monthEnd";
            this.monthEnd.TabIndex = 7;
            // 
            // lblSaleStart
            // 
            this.lblSaleStart.AutoSize = true;
            this.lblSaleStart.Location = new System.Drawing.Point(20, 6);
            this.lblSaleStart.Name = "lblSaleStart";
            this.lblSaleStart.Size = new System.Drawing.Size(79, 13);
            this.lblSaleStart.TabIndex = 9;
            this.lblSaleStart.Text = "Sale Start Date";
            // 
            // monthStart
            // 
            this.monthStart.Location = new System.Drawing.Point(20, 21);
            this.monthStart.MaxSelectionCount = 1;
            this.monthStart.Name = "monthStart";
            this.monthStart.TabIndex = 6;
            // 
            // cbYItems
            // 
            this.cbYItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbYItems.FormattingEnabled = true;
            this.cbYItems.Location = new System.Drawing.Point(217, 58);
            this.cbYItems.Name = "cbYItems";
            this.cbYItems.Size = new System.Drawing.Size(161, 306);
            this.cbYItems.TabIndex = 16;
            this.cbYItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbYItems_KeyDown);
            // 
            // cbXItems
            // 
            this.cbXItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbXItems.FormattingEnabled = true;
            this.cbXItems.Location = new System.Drawing.Point(28, 58);
            this.cbXItems.Name = "cbXItems";
            this.cbXItems.Size = new System.Drawing.Size(161, 306);
            this.cbXItems.TabIndex = 15;
            this.cbXItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbXItems_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Disc %";
            // 
            // snbDiscount
            // 
            this.snbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snbDiscount.Location = new System.Drawing.Point(386, 104);
            this.snbDiscount.Name = "snbDiscount";
            this.snbDiscount.Size = new System.Drawing.Size(66, 29);
            this.snbDiscount.TabIndex = 18;
            this.snbDiscount.Text = "100";
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(164, 362);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 28);
            this.bSave.TabIndex = 19;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNewBuyXGetYFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 399);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.snbDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbYItems);
            this.Controls.Add(this.cbXItems);
            this.Controls.Add(this.pCalendar);
            this.Controls.Add(this.snbY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.snbX);
            this.Controls.Add(this.label1);
            this.Name = "frmNewBuyXGetYFree";
            this.Text = "Add/Edit Buy X Get Y At Discount";
            this.Load += new System.EventHandler(this.frmNewBuyXGetYFree_Load);
            this.pCalendar.ResumeLayout(false);
            this.pCalendar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private clSmartNumberBox.smarttNumberBox snbX;
        private clSmartNumberBox.smarttNumberBox snbY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pCalendar;
        private System.Windows.Forms.Label lblSaleEnd;
        private System.Windows.Forms.MonthCalendar monthEnd;
        private System.Windows.Forms.Label lblSaleStart;
        private System.Windows.Forms.MonthCalendar monthStart;
        private System.Windows.Forms.ComboBox cbYItems;
        private System.Windows.Forms.ComboBox cbXItems;
        private System.Windows.Forms.Label label3;
        private clSmartNumberBox.smarttNumberBox snbDiscount;
        private System.Windows.Forms.Button bSave;
    }
}