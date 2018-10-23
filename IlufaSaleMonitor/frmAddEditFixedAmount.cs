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
    public partial class frmAddEditFixedAmount : IlufaSaleMonitor.frmAddEditSaleBase
    {
        protected new FixedAmountSale the_sale = new FixedAmountSale();

        public frmAddEditFixedAmount()
        {
            InitializeComponent();
        }

        public frmAddEditFixedAmount(FixedAmountSale a_sale)
        {
            edit_mode = true;
            this.the_sale = a_sale;
            InitializeComponent();
        }

        void initLocal()
        {
            setSaleTypeDD(3);
//            cbSaleType.SelectedIndex = 0;
//            pBuyXGetY.Enabled = false;
//            pBuyXGetY.Visible = false;
//            pPercentDiscount.Enabled = true;
//            pPercentDiscount.Visible = true;
//            //Its a Fixed discount sale so cast it properly
            nbDiscPct.Value = (decimal)the_sale.get_discount_value();
            this.BuildItemTreePctDisc();
            rtbCurrentItems.Text = the_sale.display_parameters();
        }

        private void frmAddEditFixedAmount_Load(object sender, EventArgs e)
        {
            initLocal();
        }

       /* protected override void rebuild_pct_discount_key()
        {
            bool all_supplier = true;
            //bool all_category = true;

            //recet the pct discount key
            pct_discount_key = new List<supplier_item>();
            foreach (TreeNode supplier_node in tvAll.Nodes)
            {
                all_supplier = true;
                supplier_item tmp_si = new supplier_item();
                tmp_si.item_list = new List<string>();
                tmp_si.vendor_code = supplier_node.Tag.ToString();

                foreach (TreeNode category_node in supplier_node.Nodes)
                {
                    //all_category = true;
                    foreach (TreeNode item_node in category_node.Nodes)
                    {
                        if (item_node.Checked)
                        {
                            tmp_si.item_list.Add(item_node.Tag.ToString());
                        }
                        else
                        {
                            all_supplier = false;
                            //all_category = false;
                        }
                    }
                    //all the items for this supplier are done, check and see if we can switch to ALL for the category
                    //#KM Add this soon
                    //
                }
                //categories finished, if still all category then mod to all
                if (all_supplier)
                {
                    tmp_si.item_list.Clear();
                    tmp_si.item_list.Add("ALL");
                }
                pct_discount_key.Add(tmp_si);
            }
        }
*/
        protected override void setXML()
        {
            //if (the_sale.get_sale_type() == 1)
            //{
            //    this.rebuild_pct_discount_key();
            //    the_sale.add_discount_key(this.pct_discount_key);
            //}
            this.rebuild_pct_discount_key();
            the_sale.add_discount_key(this.pct_discount_key);
            rtbCurrentItems.Text = the_sale.display_parameters();

        }

        /// <summary>
        /// Poorly named save routine
        /// </summary>
        protected override void button1_Click(object sender, EventArgs e)
        {
            //Validate for fixed amt sale
            //We need a fixed amount
            if (the_sale.get_discount_value() == 0)
            {
                MessageBox.Show("A sale of Rp. 0 is not really a sale.  Give at least 1 Rp. discount!", "Error");
                return;
            }

            if (the_sale.get_keys().Count == 0)
            {
                MessageBox.Show("Please add a supplier and items to the sale before trying to save", "Error");
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

        protected override Sale get_sale()
        {
            return the_sale;
        }

        protected override void nbDiscPct_ValueChanged(object sender, EventArgs e)
        {
            if (nbDiscPct.Value == (decimal)the_sale.get_discount_value())
                return;

            the_sale.set_discount_value((double)nbDiscPct.Value);
            this.setXML();
        }

    }
}
