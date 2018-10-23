using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IlufaSharedObjects;

namespace IlufaSaleMonitor
{
    public partial class FrmAddEditBuyXforRP : IlufaSaleMonitor.frmAddEditSaleBase
    {
        protected new BuyXForPrice the_sale = new BuyXForPrice();

        public FrmAddEditBuyXforRP()
        {
            InitializeComponent();
        }

        public FrmAddEditBuyXforRP(BuyXForPrice a_sale)
        {
            edit_mode = true;
            this.the_sale = a_sale;
            InitializeComponent();
        }

        protected override void initForDiscount()
        {
            setSaleTypeDD(2);
            nbDiscPct.Maximum = 999999999;
            nbDiscPct.ThousandsSeparator = true;

            nbDiscPct.Value = decimal.Parse( the_sale.getFixedPrice().ToString());
            //Sale tmp_sale = get_sale();
            nNumItems.Value = the_sale.get_quantity();
            this.BuildItemTreePctDisc();
            rtbCurrentItems.Text = the_sale.display_parameters();


        }

        protected override Sale get_sale()
        {
            return the_sale;
        }

        protected override void nbDiscPct_ValueChanged(object sender, EventArgs e)
        {
            if (nbDiscPct.Value == (decimal)the_sale.getFixedPrice())
                return;

            the_sale.setFixedPrice((double)nbDiscPct.Value);
            this.setXML();
        }

        private void nNumItems_ValueChanged(object sender, EventArgs e)
        {
            if (nNumItems.Value == (decimal)the_sale.get_quantity())
                return;
            the_sale.setQuantity((int) nNumItems.Value);
            this.setXML();
        }

        protected override void setXML()
        {

            this.rebuild_pct_discount_key();
            the_sale.add_discount_key(this.pct_discount_key);
            rtbCurrentItems.Text = the_sale.display_parameters();

        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            //Validate for pct discount
            //We need a pct
            if (the_sale.get_quantity() < 2)
            {
                MessageBox.Show("Sorry, but you must have a quantity more than 1. Somewhere between 2-99 is good.", "Error");
                return;
            }

            if (the_sale.getFixedPrice() < 1)
            {
                MessageBox.Show("Sorry, but you must have a price, otherwise the item would sell for free.", "Error");
                return;
            }

            if (the_sale.get_keys().Count == 0)
            {
                MessageBox.Show("Please add a supplier and items to the sale before trying to save");
                return;
            }

            if (the_sale.save())
            {
                MessageBox.Show("Sale saved");//, you can close this window or continue editing.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong, items not saved.  Contact support.", "Error");
            }
        }

        private void dtpEndDate_ValueChanged_1(object sender, EventArgs e)
        {
            the_sale.set_end_date(dtpEndDate.Value);
        }

        private void dtpStartDate_ValueChanged_1(object sender, EventArgs e)
        {
            the_sale.set_start_date(dtpStartDate.Value);
        }
    }
}

