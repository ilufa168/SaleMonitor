namespace IlufaSaleMonitor
{
    partial class frmNewSale
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
            this.cbSaleType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.tbSupplierId = new System.Windows.Forms.TextBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.monthStart = new System.Windows.Forms.MonthCalendar();
            this.monthEnd = new System.Windows.Forms.MonthCalendar();
            this.pCalendar = new System.Windows.Forms.Panel();
            this.lblSaleEnd = new System.Windows.Forms.Label();
            this.lblSaleStart = new System.Windows.Forms.Label();
            this.p11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbItemImport = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bAddAllItems = new System.Windows.Forms.Button();
            this.bLoadItems = new System.Windows.Forms.Button();
            this.bRemoveItem = new System.Windows.Forms.Button();
            this.bAddItem = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bAddCategory = new System.Windows.Forms.Button();
            this.bRemoveCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectCategories = new System.Windows.Forms.ComboBox();
            this.cbSelectedCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelectedItems = new System.Windows.Forms.ComboBox();
            this.cbDisplayItems = new System.Windows.Forms.ComboBox();
            this.bSupplierRemove = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSalePct = new System.Windows.Forms.Label();
            this.pPercentDiscount = new System.Windows.Forms.Panel();
            this.nbSalePct = new System.Windows.Forms.NumericUpDown();
            this.pCalendar.SuspendLayout();
            this.p11.SuspendLayout();
            this.pPercentDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSalePct)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSaleType
            // 
            this.cbSaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaleType.FormattingEnabled = true;
            this.cbSaleType.Location = new System.Drawing.Point(91, 15);
            this.cbSaleType.Name = "cbSaleType";
            this.cbSaleType.Size = new System.Drawing.Size(149, 21);
            this.cbSaleType.TabIndex = 1;
            this.cbSaleType.SelectedIndexChanged += new System.EventHandler(this.cbSaleType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sale Type";
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Location = new System.Drawing.Point(7, 33);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(60, 13);
            this.lblSupplierId.TabIndex = 4;
            this.lblSupplierId.Text = "Supplier Id:";
            // 
            // tbSupplierId
            // 
            this.tbSupplierId.Location = new System.Drawing.Point(72, 29);
            this.tbSupplierId.Name = "tbSupplierId";
            this.tbSupplierId.Size = new System.Drawing.Size(89, 20);
            this.tbSupplierId.TabIndex = 5;
            this.tbSupplierId.Leave += new System.EventHandler(this.tbSupplierId_Leave);
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.BackColor = System.Drawing.Color.LightGray;
            this.tbSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSupplierName.Cursor = System.Windows.Forms.Cursors.No;
            this.tbSupplierName.Enabled = false;
            this.tbSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupplierName.Location = new System.Drawing.Point(10, 55);
            this.tbSupplierName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(151, 14);
            this.tbSupplierName.TabIndex = 0;
            this.tbSupplierName.TabStop = false;
            this.tbSupplierName.WordWrap = false;
            // 
            // monthStart
            // 
            this.monthStart.Location = new System.Drawing.Point(20, 21);
            this.monthStart.MaxSelectionCount = 1;
            this.monthStart.Name = "monthStart";
            this.monthStart.TabIndex = 6;
            // 
            // monthEnd
            // 
            this.monthEnd.Location = new System.Drawing.Point(20, 211);
            this.monthEnd.MaxSelectionCount = 1;
            this.monthEnd.Name = "monthEnd";
            this.monthEnd.TabIndex = 7;
            // 
            // pCalendar
            // 
            this.pCalendar.Controls.Add(this.lblSaleEnd);
            this.pCalendar.Controls.Add(this.monthEnd);
            this.pCalendar.Controls.Add(this.lblSaleStart);
            this.pCalendar.Controls.Add(this.monthStart);
            this.pCalendar.Location = new System.Drawing.Point(700, 52);
            this.pCalendar.Name = "pCalendar";
            this.pCalendar.Size = new System.Drawing.Size(373, 380);
            this.pCalendar.TabIndex = 8;
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
            // lblSaleStart
            // 
            this.lblSaleStart.AutoSize = true;
            this.lblSaleStart.Location = new System.Drawing.Point(20, 6);
            this.lblSaleStart.Name = "lblSaleStart";
            this.lblSaleStart.Size = new System.Drawing.Size(79, 13);
            this.lblSaleStart.TabIndex = 9;
            this.lblSaleStart.Text = "Sale Start Date";
            // 
            // p11
            // 
            this.p11.Controls.Add(this.label5);
            this.p11.Controls.Add(this.tbItemImport);
            this.p11.Controls.Add(this.button1);
            this.p11.Controls.Add(this.bAddAllItems);
            this.p11.Controls.Add(this.bLoadItems);
            this.p11.Controls.Add(this.bRemoveItem);
            this.p11.Controls.Add(this.bAddItem);
            this.p11.Controls.Add(this.bSave);
            this.p11.Controls.Add(this.bAddCategory);
            this.p11.Controls.Add(this.bRemoveCategory);
            this.p11.Controls.Add(this.label1);
            this.p11.Controls.Add(this.cbSelectCategories);
            this.p11.Controls.Add(this.cbSelectedCategories);
            this.p11.Controls.Add(this.label4);
            this.p11.Controls.Add(this.cbSelectedItems);
            this.p11.Controls.Add(this.cbDisplayItems);
            this.p11.Controls.Add(this.bSupplierRemove);
            this.p11.Controls.Add(this.bAdd);
            this.p11.Controls.Add(this.cbSupplier);
            this.p11.Controls.Add(this.tbSupplierId);
            this.p11.Controls.Add(this.lblSupplierId);
            this.p11.Controls.Add(this.tbSupplierName);
            this.p11.Location = new System.Drawing.Point(12, 52);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(682, 401);
            this.p11.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 9);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enter comma seperated list of items";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbItemImport
            // 
            this.tbItemImport.Location = new System.Drawing.Point(434, 370);
            this.tbItemImport.Name = "tbItemImport";
            this.tbItemImport.Size = new System.Drawing.Size(100, 20);
            this.tbItemImport.TabIndex = 26;
            this.tbItemImport.TextChanged += new System.EventHandler(this.tbItemImport_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Import Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bAddAllItems
            // 
            this.bAddAllItems.Location = new System.Drawing.Point(427, 336);
            this.bAddAllItems.Name = "bAddAllItems";
            this.bAddAllItems.Size = new System.Drawing.Size(40, 23);
            this.bAddAllItems.TabIndex = 24;
            this.bAddAllItems.Text = ">>>";
            this.bAddAllItems.UseVisualStyleBackColor = true;
            this.bAddAllItems.Click += new System.EventHandler(this.bAddAllItems_Click);
            // 
            // bLoadItems
            // 
            this.bLoadItems.Location = new System.Drawing.Point(413, 10);
            this.bLoadItems.Name = "bLoadItems";
            this.bLoadItems.Size = new System.Drawing.Size(75, 19);
            this.bLoadItems.TabIndex = 23;
            this.bLoadItems.Text = "Load";
            this.bLoadItems.UseVisualStyleBackColor = true;
            this.bLoadItems.Click += new System.EventHandler(this.bLoadItems_Click);
            // 
            // bRemoveItem
            // 
            this.bRemoveItem.Location = new System.Drawing.Point(570, 336);
            this.bRemoveItem.Name = "bRemoveItem";
            this.bRemoveItem.Size = new System.Drawing.Size(40, 23);
            this.bRemoveItem.TabIndex = 22;
            this.bRemoveItem.Text = "<--";
            this.bRemoveItem.UseVisualStyleBackColor = true;
            this.bRemoveItem.Click += new System.EventHandler(this.bRemoveItem_Click);
            // 
            // bAddItem
            // 
            this.bAddItem.Location = new System.Drawing.Point(376, 336);
            this.bAddItem.Name = "bAddItem";
            this.bAddItem.Size = new System.Drawing.Size(40, 23);
            this.bAddItem.TabIndex = 21;
            this.bAddItem.Text = "-->";
            this.bAddItem.UseVisualStyleBackColor = true;
            this.bAddItem.Click += new System.EventHandler(this.bAddItem_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(127, 358);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 40);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "SAVE";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAddCategory
            // 
            this.bAddCategory.Location = new System.Drawing.Point(64, 336);
            this.bAddCategory.Name = "bAddCategory";
            this.bAddCategory.Size = new System.Drawing.Size(40, 23);
            this.bAddCategory.TabIndex = 20;
            this.bAddCategory.Text = "-->";
            this.bAddCategory.UseVisualStyleBackColor = true;
            this.bAddCategory.Click += new System.EventHandler(this.bAddCategory_Click);
            // 
            // bRemoveCategory
            // 
            this.bRemoveCategory.Location = new System.Drawing.Point(222, 336);
            this.bRemoveCategory.Name = "bRemoveCategory";
            this.bRemoveCategory.Size = new System.Drawing.Size(40, 23);
            this.bRemoveCategory.TabIndex = 19;
            this.bRemoveCategory.Text = "<--";
            this.bRemoveCategory.UseVisualStyleBackColor = true;
            this.bRemoveCategory.Click += new System.EventHandler(this.bRemoveCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Item Codes";
            // 
            // cbSelectCategories
            // 
            this.cbSelectCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbSelectCategories.FormattingEnabled = true;
            this.cbSelectCategories.Location = new System.Drawing.Point(8, 178);
            this.cbSelectCategories.Name = "cbSelectCategories";
            this.cbSelectCategories.Size = new System.Drawing.Size(152, 163);
            this.cbSelectCategories.TabIndex = 17;
            // 
            // cbSelectedCategories
            // 
            this.cbSelectedCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbSelectedCategories.FormattingEnabled = true;
            this.cbSelectedCategories.Location = new System.Drawing.Point(166, 178);
            this.cbSelectedCategories.Name = "cbSelectedCategories";
            this.cbSelectedCategories.Size = new System.Drawing.Size(152, 163);
            this.cbSelectedCategories.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categories";
            // 
            // cbSelectedItems
            // 
            this.cbSelectedItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbSelectedItems.FormattingEnabled = true;
            this.cbSelectedItems.Location = new System.Drawing.Point(510, 35);
            this.cbSelectedItems.Name = "cbSelectedItems";
            this.cbSelectedItems.Size = new System.Drawing.Size(161, 306);
            this.cbSelectedItems.TabIndex = 14;
            // 
            // cbDisplayItems
            // 
            this.cbDisplayItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDisplayItems.FormattingEnabled = true;
            this.cbDisplayItems.Location = new System.Drawing.Point(339, 35);
            this.cbDisplayItems.Name = "cbDisplayItems";
            this.cbDisplayItems.Size = new System.Drawing.Size(161, 306);
            this.cbDisplayItems.TabIndex = 13;
            // 
            // bSupplierRemove
            // 
            this.bSupplierRemove.Location = new System.Drawing.Point(187, 116);
            this.bSupplierRemove.Name = "bSupplierRemove";
            this.bSupplierRemove.Size = new System.Drawing.Size(75, 23);
            this.bSupplierRemove.TabIndex = 12;
            this.bSupplierRemove.Text = "Remove";
            this.bSupplierRemove.UseVisualStyleBackColor = true;
            this.bSupplierRemove.Click += new System.EventHandler(this.bSupplierRemove_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(43, 78);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 11;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(182, 10);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(98, 111);
            this.cbSupplier.TabIndex = 11;
            // 
            // lblSalePct
            // 
            this.lblSalePct.AutoSize = true;
            this.lblSalePct.Location = new System.Drawing.Point(8, 13);
            this.lblSalePct.Name = "lblSalePct";
            this.lblSalePct.Size = new System.Drawing.Size(84, 13);
            this.lblSalePct.TabIndex = 10;
            this.lblSalePct.Text = "Sale Amount (%)";
            // 
            // pPercentDiscount
            // 
            this.pPercentDiscount.Controls.Add(this.nbSalePct);
            this.pPercentDiscount.Controls.Add(this.lblSalePct);
            this.pPercentDiscount.Location = new System.Drawing.Point(280, 6);
            this.pPercentDiscount.Name = "pPercentDiscount";
            this.pPercentDiscount.Size = new System.Drawing.Size(256, 46);
            this.pPercentDiscount.TabIndex = 12;
            // 
            // nbSalePct
            // 
            this.nbSalePct.DecimalPlaces = 4;
            this.nbSalePct.Location = new System.Drawing.Point(98, 9);
            this.nbSalePct.Name = "nbSalePct";
            this.nbSalePct.Size = new System.Drawing.Size(120, 20);
            this.nbSalePct.TabIndex = 11;
            this.nbSalePct.ThousandsSeparator = true;
            // 
            // frmNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 456);
            this.Controls.Add(this.pPercentDiscount);
            this.Controls.Add(this.p11);
            this.Controls.Add(this.pCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSaleType);
            this.Name = "frmNewSale";
            this.Text = "Add/Edit Sale";
            this.Load += new System.EventHandler(this.frmNewSale_Load);
            this.pCalendar.ResumeLayout(false);
            this.pCalendar.PerformLayout();
            this.p11.ResumeLayout(false);
            this.p11.PerformLayout();
            this.pPercentDiscount.ResumeLayout(false);
            this.pPercentDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSalePct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSaleType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.TextBox tbSupplierId;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.MonthCalendar monthStart;
        private System.Windows.Forms.MonthCalendar monthEnd;
        private System.Windows.Forms.Panel pCalendar;
        private System.Windows.Forms.Label lblSaleEnd;
        private System.Windows.Forms.Label lblSaleStart;
        private System.Windows.Forms.Panel p11;
        private System.Windows.Forms.Label lblSalePct;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bSupplierRemove;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbSelectedItems;
        private System.Windows.Forms.ComboBox cbDisplayItems;
        private System.Windows.Forms.ComboBox cbSelectCategories;
        private System.Windows.Forms.ComboBox cbSelectedCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bAddCategory;
        private System.Windows.Forms.Button bRemoveCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRemoveItem;
        private System.Windows.Forms.Button bAddItem;
        private System.Windows.Forms.Button bLoadItems;
        private System.Windows.Forms.Button bAddAllItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbItemImport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pPercentDiscount;
        private System.Windows.Forms.NumericUpDown nbSalePct;
    }
}