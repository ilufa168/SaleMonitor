namespace IlufaSaleMonitor
{
    partial class frmSaleMonitor
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
            System.Windows.Forms.Label end_dateLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleMonitor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this._SaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbItemFilter = new System.Windows.Forms.TextBox();
            this.tbSupplierFilter = new System.Windows.Forms.TextBox();
            this.rbUpcoming = new System.Windows.Forms.RadioButton();
            this.rbExpired = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this._SaleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._SaleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._SaleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sale_typeTextBox = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            end_dateLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._SaleBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._SaleBindingNavigator)).BeginInit();
            this._SaleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._SaleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNew)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.BackColor = System.Drawing.Color.Linen;
            end_dateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            end_dateLabel.ForeColor = System.Drawing.Color.MediumBlue;
            end_dateLabel.Location = new System.Drawing.Point(863, 219);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(115, 17);
            end_dateLabel.TabIndex = 7;
            end_dateLabel.Text = "Last Day of Sale";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SaleBindingSource, "sale_id", true));
            label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.MediumBlue;
            label4.Location = new System.Drawing.Point(189, 13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 18);
            label4.TabIndex = 13;
            label4.Text = "sale id:";
            // 
            // _SaleBindingSource
            // 
            this._SaleBindingSource.DataSource = typeof(IlufaSharedObjects._Sale);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Linen;
            label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.MediumBlue;
            label5.Location = new System.Drawing.Point(863, 183);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 17);
            label5.TabIndex = 17;
            label5.Text = "First Day of Sale";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Linen;
            label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.MediumBlue;
            label6.Location = new System.Drawing.Point(128, 13);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 17);
            label6.TabIndex = 19;
            label6.Text = "Sale #";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRefresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbItemFilter);
            this.groupBox1.Controls.Add(this.tbSupplierFilter);
            this.groupBox1.Controls.Add(this.rbUpcoming);
            this.groupBox1.Controls.Add(this.rbExpired);
            this.groupBox1.Controls.Add(this.rbActive);
            this.groupBox1.Location = new System.Drawing.Point(70, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // bRefresh
            // 
            this.bRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRefresh.BackgroundImage")));
            this.bRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRefresh.Location = new System.Drawing.Point(689, 11);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(44, 40);
            this.bRefresh.TabIndex = 7;
            this.bRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bRefresh, "Refresh sale list");
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Supplier Id";
            // 
            // tbItemFilter
            // 
            this.tbItemFilter.Location = new System.Drawing.Point(551, 21);
            this.tbItemFilter.Name = "tbItemFilter";
            this.tbItemFilter.Size = new System.Drawing.Size(121, 21);
            this.tbItemFilter.TabIndex = 4;
            this.tbItemFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbItemFilter_KeyPress);
            // 
            // tbSupplierFilter
            // 
            this.tbSupplierFilter.Location = new System.Drawing.Point(358, 21);
            this.tbSupplierFilter.Name = "tbSupplierFilter";
            this.tbSupplierFilter.Size = new System.Drawing.Size(100, 21);
            this.tbSupplierFilter.TabIndex = 3;
            this.tbSupplierFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSupplierFilter_KeyPress);
            // 
            // rbUpcoming
            // 
            this.rbUpcoming.AutoSize = true;
            this.rbUpcoming.Location = new System.Drawing.Point(76, 22);
            this.rbUpcoming.Name = "rbUpcoming";
            this.rbUpcoming.Size = new System.Drawing.Size(82, 19);
            this.rbUpcoming.TabIndex = 2;
            this.rbUpcoming.Text = "Upcoming";
            this.rbUpcoming.UseVisualStyleBackColor = true;
            this.rbUpcoming.Click += new System.EventHandler(this.rbUpcoming_Click);
            // 
            // rbExpired
            // 
            this.rbExpired.AutoSize = true;
            this.rbExpired.Location = new System.Drawing.Point(164, 22);
            this.rbExpired.Name = "rbExpired";
            this.rbExpired.Size = new System.Drawing.Size(66, 19);
            this.rbExpired.TabIndex = 1;
            this.rbExpired.Text = "Expired";
            this.rbExpired.UseVisualStyleBackColor = true;
            this.rbExpired.Click += new System.EventHandler(this.rbExpired_Click);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(14, 22);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(56, 19);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.Click += new System.EventHandler(this.rbActive_Click);
            // 
            // _SaleBindingNavigator
            // 
            this._SaleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._SaleBindingNavigator.BindingSource = this._SaleBindingSource;
            this._SaleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._SaleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._SaleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this._SaleBindingNavigatorSaveItem});
            this._SaleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._SaleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._SaleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._SaleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._SaleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._SaleBindingNavigator.Name = "_SaleBindingNavigator";
            this._SaleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._SaleBindingNavigator.Size = new System.Drawing.Size(1238, 25);
            this._SaleBindingNavigator.TabIndex = 1;
            this._SaleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _SaleBindingNavigatorSaveItem
            // 
            this._SaleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._SaleBindingNavigatorSaveItem.Enabled = false;
            this._SaleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_SaleBindingNavigatorSaveItem.Image")));
            this._SaleBindingNavigatorSaveItem.Name = "_SaleBindingNavigatorSaveItem";
            this._SaleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this._SaleBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // _SaleDataGridView
            // 
            this._SaleDataGridView.AllowUserToResizeColumns = false;
            this._SaleDataGridView.AutoGenerateColumns = false;
            this._SaleDataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this._SaleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._SaleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this._SaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._SaleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this._SaleDataGridView.DataSource = this._SaleBindingSource;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._SaleDataGridView.DefaultCellStyle = dataGridViewCellStyle28;
            this._SaleDataGridView.EnableHeadersVisualStyles = false;
            this._SaleDataGridView.Location = new System.Drawing.Point(79, 65);
            this._SaleDataGridView.MultiSelect = false;
            this._SaleDataGridView.Name = "_SaleDataGridView";
            this._SaleDataGridView.ReadOnly = true;
            this._SaleDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this._SaleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._SaleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._SaleDataGridView.Size = new System.Drawing.Size(767, 613);
            this._SaleDataGridView.TabIndex = 2;
            this._SaleDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._SaleDataGridView_CellContentDoubleClick);
            this._SaleDataGridView.DoubleClick += new System.EventHandler(this._SaleDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sale_id";
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.MediumBlue;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn1.HeaderText = "Sale Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "start_date";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.MediumBlue;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Day of Sale";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "end_date";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.MediumBlue;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Day of Sale";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sale_type";
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.MediumBlue;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn5.HeaderText = "Type of Sale";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "parameters";
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.MediumBlue;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn4.HeaderText = "Sale Parameters <xml>";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 350;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 350;
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Linen;
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._SaleBindingSource, "start_date", true));
            this.start_dateDateTimePicker.Enabled = false;
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(986, 181);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(226, 21);
            this.start_dateDateTimePicker.TabIndex = 6;
            // 
            // end_dateDateTimePicker
            // 
            this.end_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._SaleBindingSource, "end_date", true));
            this.end_dateDateTimePicker.Enabled = false;
            this.end_dateDateTimePicker.Location = new System.Drawing.Point(986, 217);
            this.end_dateDateTimePicker.Name = "end_dateDateTimePicker";
            this.end_dateDateTimePicker.Size = new System.Drawing.Size(226, 21);
            this.end_dateDateTimePicker.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Linen;
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SaleBindingSource, "parameters", true));
            this.richTextBox1.Location = new System.Drawing.Point(852, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(373, 430);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // sale_typeTextBox
            // 
            this.sale_typeTextBox.BackColor = System.Drawing.Color.Linen;
            this.sale_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SaleBindingSource, "sale_type", true));
            this.sale_typeTextBox.Enabled = false;
            this.sale_typeTextBox.Location = new System.Drawing.Point(139, 47);
            this.sale_typeTextBox.Name = "sale_typeTextBox";
            this.sale_typeTextBox.Size = new System.Drawing.Size(100, 21);
            this.sale_typeTextBox.TabIndex = 11;
            // 
            // bNew
            // 
            this.bNew.BackColor = System.Drawing.Color.Gainsboro;
            this.bNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bNew.BackgroundImage")));
            this.bNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bNew.InitialImage = null;
            this.bNew.Location = new System.Drawing.Point(7, 112);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(64, 64);
            this.bNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bNew.TabIndex = 14;
            this.bNew.TabStop = false;
            this.toolTip1.SetToolTip(this.bNew, "Create a new sale");
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEdit.BackgroundImage")));
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEdit.Location = new System.Drawing.Point(7, 182);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(64, 64);
            this.bEdit.TabIndex = 16;
            this.toolTip1.SetToolTip(this.bEdit, "Edit selected sale");
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click_1);
            // 
            // bDelete
            // 
            this.bDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDelete.BackgroundImage")));
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDelete.Location = new System.Drawing.Point(7, 391);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(64, 64);
            this.bDelete.TabIndex = 19;
            this.toolTip1.SetToolTip(this.bDelete, "Delete selected sale");
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCopy
            // 
            this.bCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCopy.BackgroundImage")));
            this.bCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCopy.Location = new System.Drawing.Point(7, 252);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(64, 64);
            this.bCopy.TabIndex = 20;
            this.toolTip1.SetToolTip(this.bCopy, "Copy and edit selected sale");
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bCopy);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.bEdit);
            this.panel1.Controls.Add(this._SaleDataGridView);
            this.panel1.Controls.Add(this.bNew);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(end_dateLabel);
            this.panel1.Controls.Add(this.start_dateDateTimePicker);
            this.panel1.Controls.Add(this.end_dateDateTimePicker);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 685);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.sale_typeTextBox);
            this.panel2.Location = new System.Drawing.Point(852, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 179);
            this.panel2.TabIndex = 18;
            // 
            // frmSaleMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 711);
            this.Controls.Add(this._SaleBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaleMonitor";
            this.Text = "Ilufa Sales Monitor - Main";
            this.Load += new System.EventHandler(this.frmSaleMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this._SaleBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._SaleBindingNavigator)).EndInit();
            this._SaleBindingNavigator.ResumeLayout(false);
            this._SaleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._SaleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNew)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUpcoming;
        private System.Windows.Forms.RadioButton rbExpired;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.BindingSource _SaleBindingSource;
        private System.Windows.Forms.BindingNavigator _SaleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton _SaleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView _SaleDataGridView;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateDateTimePicker;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbItemFilter;
        private System.Windows.Forms.TextBox tbSupplierFilter;
        private System.Windows.Forms.TextBox sale_typeTextBox;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.PictureBox bNew;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}