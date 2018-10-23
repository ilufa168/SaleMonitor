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
    public partial class frmAddEditSale : Form
    {
        PercentDiscountSale the_sale = new PercentDiscountSale();
        List<VendorCategoryItems> vendor_items = new List<VendorCategoryItems>();
        //Matches the key on pct discount sale
        public List<supplier_item> pct_discount_key = new List<supplier_item>();
        bool _skipCheckEvents = false;

        public bool edit_mode = false;
        public frmAddEditSale()
        {
            edit_mode = false;
            InitializeComponent();
        }

        public frmAddEditSale(PercentDiscountSale a_sale)
        {
            edit_mode = true;
            this.the_sale = a_sale;
            InitializeComponent();
        }

        private void frmAddEditSale_Load(object sender, EventArgs e)
        {
            if (edit_mode)  //set up the controls in edit mode
            {
                this.initControlsForEdit();
            }
        }

        protected void initForDiscount()
        {
            setSaleTypeDD(0);
            pBuyXGetY.Enabled = false;
            pBuyXGetY.Visible = false;
            pPercentDiscount.Enabled = true;
            pPercentDiscount.Visible = true;
            //Its a percent discount sale so cast it properly
            nbDiscPct.Value = (decimal) the_sale.get_discount_value();
            this.BuildItemTreePctDisc();
            rtbCurrentItems.Text = the_sale.display_parameters();
        }

        protected void setSaleTypeDD(int xx)
        {
            this.cbSaleType.SelectedIndex = xx;
        }
        private void BuildItemTreePctDisc()
        {
            int tree_idx = 0;
            bool check_all_item = false;
            PercentDiscountSale current_sale = the_sale;
            _skipCheckEvents = true;

            foreach (supplier_item si in the_sale.get_keys())
            {
                //retrieve the master item list for this supplier
                vendor_items.Add(new VendorCategoryItems(si.vendor_code));
                if (current_sale.all_items(si.vendor_code))
                {
                    check_all_item = true;
                }
                //Order the item list for sanity
            }
            //Build a full tree based on vendor code / category / item
            int cat_idx = 0;
            bool check_all_cat_item = false;
            foreach (VendorCategoryItems vci in vendor_items)
            {
                TreeNode top = new TreeNode(vci.getSupplierName());
                top.Tag = vci.getSupplierCode();
                if (check_all_item)
                    top.Checked = true;
                   
                tvAll.Nodes.Add(top);
                foreach (vendor_categories vc in vci.getCategoryList())
                {
                    TreeNode tmpCat = new TreeNode(vc.category_title);
                    
                    if (check_all_item)
                        tmpCat.Checked = true;
                    tvAll.Nodes[tree_idx].Nodes.Add(tmpCat);

                    foreach (category_items ci in vc.items)
                    {
                        TreeNode tmp = new TreeNode(ci.long_name);
                        tmp.Name = ci.item_code;

                        if (check_all_item )
                            tmp.Checked = true;
                            //allModel.Nodes[tree_idx].Nodes[cat_idx].Nodes[allModel.Nodes[tree_idx].Nodes[cat_idx]..GetNodeCount(false) - 1].IsChecked = true;
                        else
                        {
                             if (current_sale.check_for_sale(vci.getSupplierCode(),vc.category_code,ci.item_code))
                             {
                                tmp.Checked = true;
                                tvAll.Nodes[tree_idx].Checked = true;
                                tvAll.Nodes[tree_idx].Nodes[cat_idx].Checked = true;
                             }
                        }
                        tmp.Tag = ci.item_code;

                        tvAll.Nodes[tree_idx].Nodes[cat_idx].Nodes.Add(tmp);

                    }
                    cat_idx++;
                }
                //Now add any item codes to the tree

                tree_idx++;
            }
            _skipCheckEvents = false;
        }

        private void rebuild_pct_discount_key()
        {
            bool all_supplier = true;
            bool all_category = true;

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
                    all_category = true;
                    foreach(TreeNode item_node in category_node.Nodes)
                    {
                        if (item_node.Checked)
                        {
                            tmp_si.item_list.Add(item_node.Tag.ToString());
                        } else
                        {
                            all_supplier = false;
                            all_category = false;
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

        private void initControlsForEdit()
        {
            //Set some common text fields
            lblSaleId.Text = the_sale.get_sale_id().ToString();
            //mcStartDate.SetDate(the_sale.get_start_date());
            dtpStartDate.Value = the_sale.get_start_date();
            //mcEndDate.SetDate(the_sale.get_end_date());
            dtpEndDate.Value = the_sale.get_end_date();

            this.initForDiscount();
            //Set the % sale mode
 //           switch (the_sale.get_sale_type())
 //           {
 //               case 1: //Regular % discount sale
 //                   this.initForDiscount();
 //                   break;
 //               case 2: //Fixed Amount discount sale
 //                   break;
 //               default:
 //                   break;
 //           }
            cbSaleType.Enabled = false;

        }

        private void setXML()
        {
            if (the_sale.get_sale_type() == 1)
            {
                this.rebuild_pct_discount_key();
                the_sale.add_discount_key(this.pct_discount_key);
            }

            rtbCurrentItems.Text = the_sale.display_parameters();

        }

        private void tvAll_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void tvAll_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void refreshTreeViewAfterClick()
        {
            

            //Go through all the children, make sure the parent matches the siblings
            foreach(TreeNode t_supplier in tvAll.Nodes)
            {
                bool state_top = false;
                
                foreach (TreeNode t_category in t_supplier.Nodes)
                {
                    bool state_cat = false;
                    foreach (TreeNode t_item in t_category.Nodes)
                    {
                        if (t_item.Checked)
                        {
                            state_cat = true;
                            break;
                        }
                    }
                    if (state_cat)
                        state_top = true;
                    t_category.Checked = state_cat;
                }
                t_supplier.Checked = state_top;
            }
            this.setXML();
        }
        private void tvAll_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (_skipCheckEvents)
                return;

            _skipCheckEvents = true;
            TreeNode the_node = e.Node;

            //First update any children
            foreach(TreeNode tn in the_node.Nodes)
            {
                tn.Checked = the_node.Checked;
                //tn.StateImageIndex = 2;
                //And the childrens children
                foreach (TreeNode tnd in tn.Nodes)
                {
                    tnd.Checked = tn.Checked;
                }
            }

            this.refreshTreeViewAfterClick();

            /*
            if (the_node.Level > 0)
            {
                //Now force the parent to update
                bool found = false;
                TreeNode parent = the_node.Parent;
                foreach (TreeNode tnd in parent.Nodes)
                {
                    if (tnd.Checked)
                    {
                        found = true;
                        break;
                    }
                }
                parent.Checked = found;
            }
            */
            _skipCheckEvents = false;
           
            return;
        }

        private void bAddSupplier_Click(object sender, EventArgs e)
        {
            if (tbSupplier.Text.Length == 0)
                return;

            //MessageBox.Show("Adding Supplier " + tbSupplier.Text);
            //First make sure this supplier exists
            Vendor v = new Vendor(tbSupplier.Text);

            if (v.vendor_code == "0")
            {
                MessageBox.Show("Supplier not found, check the code and try again");
                return;
            }
            
            //Add the supplier
            the_sale.addSupplier(v);
            this.BuildItemTreePctDisc();

        }

        private void nbDiscPct_ValueChanged(object sender, EventArgs e)
        {
            if (nbDiscPct.Value == (decimal)the_sale.get_discount_value())
                return;

            the_sale.set_discount_value((double) nbDiscPct.Value);
            this.setXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validate for pct discount
            //We need a pct
            if (the_sale.get_discount_value() == 0)
            {
                MessageBox.Show("There must be a discount value more than 0!, not saving.", "Error");
                return;
            }

            if (the_sale.get_keys().Count == 0)
            {
                MessageBox.Show("Please add a supplier to the sale before trying to save");
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


        private void tbItemCodes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //split into array based on commas
                string[] new_items = tbItemCodes.Text.Split(',');

                if (new_items.Count() == 0) return;

                foreach (string an_item in new_items)
                {
                    TreeNode[] fnd = tvAll.Nodes.Find(an_item, true);
                    if (fnd.Count() == 0)
                    {
                        MessageBox.Show("Requested item [" + an_item + "] not found");

                    }
                    else
                    {
                        foreach (TreeNode a_node in fnd)  //Should only be one but heyhey
                        {
                            a_node.Checked = true;
                        }
                    }
                }
            }
        }

        private void tbSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bAddSupplier_Click(this,e);
            }
        }

        private void tbItemCodes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.the_sale.set_start_date(dtpStartDate.Value);
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.the_sale.set_end_date(dtpEndDate.Value);
        }

        private void cbSaleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }




}
