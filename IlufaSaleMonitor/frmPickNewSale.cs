using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IlufaSharedObjects;

namespace IlufaSaleMonitor
{
    public partial class frmPickNewSale : Form
    {
        List<_Sale_Type> sales_types = new List<_Sale_Type>();
        private int selected_type = -1;

        public frmPickNewSale()
        {
            InitializeComponent();
        }

        private void frmPickNewSale_Load(object sender, EventArgs e)
        {
            sales_types = Sale.loadSalesTypes();
            //cbSaleType.DataSource = sales_types;
            //cbSaleType.DisplayMember = "pos_sale_type_desc";
            //cbSaleType.ValueMember = "pos_sale_type_id";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public int getSelectedSaleType()
        {
           

            return this.selected_type;

        }

        private void bPctDiscount_Click(object sender, EventArgs e)
        {
            this.selected_type = 1;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.selected_type = 2;
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selected_type = 3;
            DialogResult = DialogResult.OK;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bFixedPrice_Click(object sender, EventArgs e)
        {
            this.selected_type = 4;
            DialogResult = DialogResult.OK;
        }
    }
}
