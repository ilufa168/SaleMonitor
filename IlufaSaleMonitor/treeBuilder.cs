using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IlufaSharedObjects;
using System.Windows.Forms;

namespace IlufaSaleMonitor
{
    public class treeBuilder
    {
        public Sale the_sale;
//        private PercentDiscountSale current_sale;
        List<VendorCategoryItems> vendor_items = new List<VendorCategoryItems>();

        //        public treeBuilder(PercentDiscountSale current_sale)
        //        {
        //            this.current_sale = current_sale;
        //        }

        public treeBuilder(Sale a_sale)
        {
            if (a_sale.get_sale_type() ==1)
            {
                the_sale = new PercentDiscountSale();
                the_sale = a_sale;
            } else if (a_sale.get_sale_type() == 2)
            {
                the_sale = new FixedAmountSale();
                the_sale = a_sale;
            }
        }

        public TreeView BuildSupplierSaleTree()
        {
            TreeView result = new TreeView();
            bool check_all_item = false;
            int tree_idx = 0;

            foreach (supplier_item si in the_sale.get_keys())
            {
                //retrieve the master item list for this supplier
                vendor_items.Add(new VendorCategoryItems(si.vendor_code));

                if (the_sale.all_items(si.vendor_code))
                {
                    check_all_item = true;
                }
                //Order the item list for sanity
            }
            //Build a full tree based on vendor code / category / item
            int cat_idx = 0;
            //bool check_all_cat_item = false;
            foreach (VendorCategoryItems vci in vendor_items)
            {
                TreeNode top = new TreeNode(vci.getSupplierName());
                top.Tag = vci.getSupplierCode();
                if (check_all_item)
                    top.Checked = true;

                result.Nodes.Add(top);
                foreach (vendor_categories vc in vci.getCategoryList())
                {
                    TreeNode tmpCat = new TreeNode(vc.category_title);

                    if (check_all_item)
                        tmpCat.Checked = true;
                    result.Nodes[tree_idx].Nodes.Add(tmpCat);

                    foreach (category_items ci in vc.items)
                    {
                        TreeNode tmp = new TreeNode(ci.long_name);
                        tmp.Name = ci.item_code;

                        if (check_all_item)
                            tmp.Checked = true;
                        //allModel.Nodes[tree_idx].Nodes[cat_idx].Nodes[allModel.Nodes[tree_idx].Nodes[cat_idx]..GetNodeCount(false) - 1].IsChecked = true;
                        else
                        {
                            switch (the_sale.get_sale_type()) {
                                case 1:
                                    PercentDiscountSale tmp_sale = (PercentDiscountSale) the_sale;
                                    if (tmp_sale.check_for_sale(vci.getSupplierCode(), vc.category_code, ci.item_code))
                                    {
                                        tmp.Checked = true;
                                        result.Nodes[tree_idx].Checked = true;
                                        result.Nodes[tree_idx].Nodes[cat_idx].Checked = true;
                                    }
                                    break;
                            }

                        }
                        tmp.Tag = ci.item_code;

                        result.Nodes[tree_idx].Nodes[cat_idx].Nodes.Add(tmp);

                    }
                    cat_idx++;
                }
                //Now add any item codes to the tree

                tree_idx++;
            }
           // _skipCheckEvents = false;
            return result;
        }
    }
}
