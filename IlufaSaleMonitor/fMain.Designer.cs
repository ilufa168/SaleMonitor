namespace IlufaSaleMonitor
{
    partial class IlufaSameMonitor
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
            this.bNewSale = new System.Windows.Forms.Button();
            this.tabSales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgCurrentSales = new System.Windows.Forms.DataGridView();
            this.sale_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_source_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgFutureSales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgExpiredSales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbKey = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuyXYFree = new System.Windows.Forms.Button();
            this.tabSales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFutureSales)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpiredSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bNewSale
            // 
            this.bNewSale.Location = new System.Drawing.Point(26, 28);
            this.bNewSale.Name = "bNewSale";
            this.bNewSale.Size = new System.Drawing.Size(64, 38);
            this.bNewSale.TabIndex = 0;
            this.bNewSale.Text = "New % Dsc";
            this.bNewSale.UseVisualStyleBackColor = true;
            this.bNewSale.Click += new System.EventHandler(this.bNewSale_Click);
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.tabPage1);
            this.tabSales.Controls.Add(this.tabPage2);
            this.tabSales.Controls.Add(this.tabPage3);
            this.tabSales.Location = new System.Drawing.Point(121, 12);
            this.tabSales.Name = "tabSales";
            this.tabSales.SelectedIndex = 0;
            this.tabSales.Size = new System.Drawing.Size(724, 305);
            this.tabSales.TabIndex = 1;
            this.tabSales.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgCurrentSales);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgCurrentSales
            // 
            this.dgCurrentSales.AutoGenerateColumns = false;
            this.dgCurrentSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrentSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_id,
            this.sale_type,
            this.sale_source_type,
            this.parameters});
            this.dgCurrentSales.DataSource = this.saleBindingSource;
            this.dgCurrentSales.Location = new System.Drawing.Point(6, 3);
            this.dgCurrentSales.Name = "dgCurrentSales";
            this.dgCurrentSales.Size = new System.Drawing.Size(704, 270);
            this.dgCurrentSales.TabIndex = 0;
            this.dgCurrentSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCurrentSales_CellContentClick);
            // 
            // sale_id
            // 
            this.sale_id.DataPropertyName = "sale_id";
            this.sale_id.HeaderText = "Id";
            this.sale_id.Name = "sale_id";
            this.sale_id.Width = 20;
            // 
            // sale_type
            // 
            this.sale_type.DataPropertyName = "sale_type";
            this.sale_type.HeaderText = "Sale Type";
            this.sale_type.Name = "sale_type";
            // 
            // sale_source_type
            // 
            this.sale_source_type.DataPropertyName = "sale_source_type";
            this.sale_source_type.HeaderText = "Source";
            this.sale_source_type.Name = "sale_source_type";
            // 
            // parameters
            // 
            this.parameters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.parameters.DataPropertyName = "parameters";
            this.parameters.HeaderText = "Description";
            this.parameters.Name = "parameters";
            this.parameters.ReadOnly = true;
            this.parameters.Width = 85;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgFutureSales);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Future Sales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgFutureSales
            // 
            this.dgFutureSales.AutoGenerateColumns = false;
            this.dgFutureSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFutureSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgFutureSales.DataSource = this.saleBindingSource;
            this.dgFutureSales.Location = new System.Drawing.Point(6, 4);
            this.dgFutureSales.Name = "dgFutureSales";
            this.dgFutureSales.Size = new System.Drawing.Size(704, 270);
            this.dgFutureSales.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sale_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "sale_type";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sale Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "sale_source_type";
            this.dataGridViewTextBoxColumn10.HeaderText = "Source";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "parameters";
            this.dataGridViewTextBoxColumn11.HeaderText = "Description";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 500;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgExpiredSales);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Expired Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgExpiredSales
            // 
            this.dgExpiredSales.AutoGenerateColumns = false;
            this.dgExpiredSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExpiredSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn12});
            this.dgExpiredSales.DataSource = this.saleBindingSource;
            this.dgExpiredSales.Location = new System.Drawing.Point(6, 4);
            this.dgExpiredSales.Name = "dgExpiredSales";
            this.dgExpiredSales.Size = new System.Drawing.Size(704, 270);
            this.dgExpiredSales.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sale_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sale_type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sale Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sale_source_type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Source";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "parameters";
            this.dataGridViewTextBoxColumn12.HeaderText = "Description";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 500;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(26, 247);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(64, 60);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete Selected Sale";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(26, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit Selected Sale";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.rbKey);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(121, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 100);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(190, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Item Code";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbKey
            // 
            this.rbKey.AutoSize = true;
            this.rbKey.Location = new System.Drawing.Point(190, 24);
            this.rbKey.Name = "rbKey";
            this.rbKey.Size = new System.Drawing.Size(128, 17);
            this.rbKey.TabIndex = 2;
            this.rbKey.TabStop = true;
            this.rbKey.Text = "Key (ex Vendor Code)";
            this.rbKey.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find A Sale (Search Current Tab)";
            // 
            // bBuyXYFree
            // 
            this.bBuyXYFree.Location = new System.Drawing.Point(26, 72);
            this.bBuyXYFree.Name = "bBuyXYFree";
            this.bBuyXYFree.Size = new System.Drawing.Size(64, 38);
            this.bBuyXYFree.TabIndex = 5;
            this.bBuyXYFree.Text = "New Buy X/Y Free";
            this.bBuyXYFree.UseVisualStyleBackColor = true;
            this.bBuyXYFree.Click += new System.EventHandler(this.bBuyXYFree_Click);
            // 
            // IlufaSameMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 427);
            this.Controls.Add(this.bBuyXYFree);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.tabSales);
            this.Controls.Add(this.bNewSale);
            this.Name = "IlufaSameMonitor";
            this.Text = "Sale Monitor";
            this.Load += new System.EventHandler(this.IlufaSameMonitor_Load);
            this.tabSales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFutureSales)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgExpiredSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNewSale;
        private System.Windows.Forms.TabControl tabSales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgCurrentSales;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.DataGridView dgExpiredSales;
        private System.Windows.Forms.DataGridView dgFutureSales;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBuyXYFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_source_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameters;
    }
}

