using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.Oracle;
using IlufaSharedObjects;


namespace IlufaSaleMonitor
{


    public partial class frmNewSale : Form
    {
        OracleHandler oh;
        List<sale_type> st_id = new List<sale_type>();
        List<supplier> lst_supplier = new List<supplier>();
        BindingList<string> key_list = new BindingList<string>();
        BindingList<codes> lst_select_categories = new BindingList<codes>();
        BindingList<codes> lst_selected_categories = new BindingList<codes>();
        BindingList<sales_item> lst_display_items = new BindingList<sales_item>();
        BindingList<sales_item> lst_selected_item_display = new BindingList<sales_item>();
        List<sales_item> lst_selected_items = new List<sales_item>();

        public frmNewSale()
        {
            InitializeComponent();            
        }

        private void frmNewSale_Load(object sender, EventArgs e)
        {
            oh = new OracleHandler();
            this.load_sale_type();
            this.load_supplier_list();
            this.load_codes();
            this.cbSaleType.DataSource = st_id;
            this.cbSelectCategories.DataSource = lst_select_categories;
            this.cbSelectedCategories.DataSource = lst_selected_categories;
            this.cbSupplier.DataSource = key_list;
            this.cbSelectedItems.DataSource = lst_selected_item_display;
            this.cbSaleType.SelectedIndex = 1;
            this.cbSaleType.Enabled = false;
            this.Refresh();

        }

        private bool load_codes()
        {
            OracleDataReader odr;
            codes a_code = new codes();

            a_code.code = "ALL";
            a_code.code_description = "ALL-CATEGORIES";

            lst_select_categories.Add(a_code);

            //Connect to oracle
            if (!(oh.connect()))
                return false;

            string sql = "select code, description from erp.codes where kind='ITEM_CATEGORY'";

            if (!oh.DoQuery(sql))
                return false;

            if (oh.getRowCount() >= 1)
            {
                odr = oh.odr;
                while (odr.Read())
                {
                    a_code = new codes();
                    a_code.code = odr.GetString(0);
                    a_code.code_description = odr.GetString(1);
                    lst_select_categories.Add(a_code);
                }
                odr.Dispose();
            }

            oh.disconnect();

            return true;
        }

        private bool load_sale_type()
        {
            OracleDataReader odr;
            sale_type ss = new sale_type();
            ss.sale_type_id = 0;
            ss.sale_type_description = "";
            st_id.Add(ss);

            if (!(oh.connect()))
                return false;

            string sql = "select pos_sale_type_id,pos_sale_type_desc from pos_sale_type ";

            if (!oh.DoQuery(sql))
                return false;

            if (oh.getRowCount() >= 1)
            {
                odr = oh.odr;
                while (odr.Read())
                {
                    ss = new sale_type();
                    decimal tmp;
                    tmp = odr.GetDecimal(0);
                    ss.sale_type_id = (int)tmp;
                    ss.sale_type_description = odr.GetString(1);
                    st_id.Add(ss);
                }
                odr.Dispose();
            }
            oh.disconnect();

            return true;
        }

        private bool load_supplier_list()
        {
            OracleDataReader odr;
            supplier ss = new supplier();
//            ss.sale_type_id = 0;
//            ss.sale_type_description = "";
//            st_id.Add(ss);

            if (!(oh.connect()))
                return false;

            string sql = "select vendor_code,nvl(vendor_name,'NONE') from erp.vendor";

            if (!oh.DoQuery(sql))
                return false;

            if (oh.getRowCount() >= 1)
            {
                odr = oh.odr;
                while (odr.Read())
                {
                    ss = new supplier();
                    ss.supplier_id = odr.GetString(0);
                    ss.supplier_name = odr.GetString(1);
                    this.lst_supplier.Add(ss);
                }
                odr.Dispose();
            }
            oh.disconnect();

            return true;
        }

        private void cbSaleSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSaleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbSelectCategories.Refresh();
        }

        private void tbSupplierId_Leave(object sender, EventArgs e)
        {
            //Search the supplier list for a match, then set the name
            string search = tbSupplierId.Text.ToUpper();
            tbSupplierId.Text = search;
            supplier match = lst_supplier.Find(
                delegate(supplier sp)
                {
                    return sp.supplier_id == search;
                }
            );

           if (match.supplier_name == null)
            {
                this.tbSupplierName.Text = "NOT FOUND";
            }
            else
            {
                this.tbSupplierName.Text = match.supplier_name;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Sale the_sale;
            sale_type ss = new sale_type();         
//            sale_source_type st = new sale_source_type();

//            st = (sale_source_type)this.cbSaleSourceType.SelectedValue;
            ss = (sale_type)this.cbSaleType.SelectedValue;

            switch (ss.sale_type_id)
            {
                case 1:
                    the_sale = new PercentDiscountSale();
                    string txt = nbSalePct.Text;// snbSaleAmount.Text; 
                    double tmp = double.Parse(txt);
                    //the_sale.set_discount_value((double.Parse(this.snbSaleAmount.Text)));
                    the_sale.set_discount_value(tmp);

                    foreach (sales_item an_item in lst_selected_items)
                    {
                        the_sale.add_sale_parameter(an_item);
                    }
                    break;
                default:
                    MessageBox.Show("Something odd is happening, sale not saved");
                    return;
            }

            the_sale.set_start_date(monthStart.SelectionStart);
            the_sale.set_end_date(monthEnd.SelectionStart);
            the_sale.set_sale_source_type(2); //Set to 2, 1 is being temporarily used to depreciate old xml format
            the_sale.set_sale_type(ss.sale_type_id);

            if (!the_sale.validate())
                //Get the errors from the_sale, and display them
                return;

            if (!the_sale.save())
            {
                MessageBox.Show("Error saving the sale"); //add real error checking here
                return;
            }

            MessageBox.Show("Sale added");

            DialogResult = DialogResult.OK;
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (this.tbSupplierId.TextLength > 0 && tbSupplierName.Text != "NOT FOUND" && key_list.IndexOf(tbSupplierId.Text) == -1)
            {
                key_list.Add(tbSupplierId.Text);
//                this.cbSupplier.DataSource = key_list;
                cbSupplier.Refresh();
            }
        }

        private void bSupplierRemove_Click(object sender, EventArgs e)
        {
            int idx = cbSupplier.SelectedIndex;
            if (idx > -1)
            {
                string remove = cbSupplier.Items[idx].ToString();
                key_list.Remove(remove);
            }
        }

        private void bAddCategory_Click(object sender, EventArgs e)
        {
            int idx = cbSelectCategories.SelectedIndex;
            if (idx > -1)
            {
                codes a_code = (codes) cbSelectCategories.Items[idx];
                if (a_code.code == "ALL")
                {
                    lst_selected_categories.Clear();
                }
                else
                {
                    if (lst_selected_categories.Count == 1 && lst_selected_categories[0].code == "ALL")
                        lst_selected_categories.Clear();
                }
                lst_selected_categories.Add(a_code);
                cbSelectedCategories.Refresh();
            }
        }

        private void bRemoveCategory_Click(object sender, EventArgs e)
        {
            int idx = cbSelectedCategories.SelectedIndex;
            if (idx > -1)
            {
                codes a_code = (codes)cbSelectedCategories.Items[idx];
                lst_selected_categories.Remove(a_code);
            }
        }

        private void bLoadItems_Click(object sender, EventArgs e)
        {
            if (cbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier first");
                return;
            }

//            if (lst_selected_categories.Count == 0)
//            {
//                MessageBox.Show("Add one or more categories first");
//                return;
//            }

            this.load_items();

            this.cbDisplayItems.DataSource = lst_display_items;
            this.cbDisplayItems.Refresh();
            this.update_selected_item_display();
            return;
        }

        private void load_items()
        {
            OracleDataReader odr;
            sales_item an_item;

            lst_display_items = new BindingList<sales_item>();

            string selected = (string) cbSupplier.Items[cbSupplier.SelectedIndex];
            string sql = "select item_code, item_name, vendor_code from erp.item " +
                         "where vendor_code = '" + selected + "'" + "order by item_code asc";

            an_item = new sales_item();
            an_item.item_code = "ALL";
            an_item.item_name = "ALL ITEMS FOR SUPPLIER";
            an_item.vendor_code = selected;

            this.lst_display_items.Add(an_item);

            if (!(oh.connect()))
                return;

            if (!oh.DoQuery(sql))
                return;

            if (oh.getRowCount() >= 1)
            {
                odr = oh.odr;
                while (odr.Read())
                {
                    an_item = new sales_item();
                    an_item.item_code = odr.GetString(0);
                    an_item.item_name = odr.GetString(1);
                    an_item.vendor_code = odr.GetString(2);
                    this.lst_display_items.Add(an_item);
                }
                odr.Dispose();
            }
            oh.disconnect();
            return;
        }

        private void update_selected_item_display()
        {
            int idx = this.cbSupplier.SelectedIndex;
            string supplier = this.cbSupplier.Items[idx].ToString();
            //Clear the display list
            this.lst_selected_item_display.Clear();
            foreach (sales_item an_item in lst_selected_items)
            {
                if (an_item.vendor_code == supplier)
                    lst_selected_item_display.Add(an_item);
            }
        }

        private void add_item(sales_item an_item)
        {
            sales_item match;
            if (an_item.item_code == "ALL") //If adding all items, remove any existing ones
            {
                // Remove all the existing item codes for that vendor

                do
                {
                    match = lst_selected_items.Find(
                        delegate(sales_item tmp)
                        {
                            return tmp.vendor_code == an_item.vendor_code;
                        }
                    );
                    if (match.vendor_code != null)
                        lst_selected_items.Remove(match);

                } while (match.item_name != null);

                foreach (sales_item tmp in lst_selected_items)
                {
                    if (tmp.vendor_code == an_item.vendor_code)
                        lst_selected_items.Remove(tmp);
                }
            }

            //Adding a real item code, delete the "ALL" option
            List<sales_item> lst_match = lst_selected_items.FindAll(
                delegate(sales_item tmp)
                {
                    return tmp.vendor_code == an_item.vendor_code;
                }
            );

            if (lst_match.Count > 0)
            {
                sales_item tmp = lst_match.Find(
                    delegate(sales_item dlgtmp)
                    {
                        return dlgtmp.item_code == "ALL";
                    }
                );
                if (tmp.item_code != null)
                    lst_selected_items.Remove(tmp);
            }

            //Finally, look for the item number (always unique) and add it if its not there
            match = lst_selected_items.Find(
                delegate(sales_item tmp)
                {
                    return tmp.item_code == an_item.item_code;
                }
            );

            //If we do not have it in the list, add it otherwise, its already there do not add again
            if (match.item_name == null)
                lst_selected_items.Add(an_item);

        }

        private void bAddItem_Click(object sender, EventArgs e)
        {
            int idx = this.cbDisplayItems.SelectedIndex;
            if (idx > -1)
            {
                sales_item an_item = (sales_item)cbDisplayItems.Items[idx];

                this.add_item(an_item);
                this.update_selected_item_display();
            }
        }

        private void bAddAllItems_Click(object sender, EventArgs e)
        {
            sales_item match;
            if (cbSupplier.SelectedIndex < 0)
                return;

            string vendor = this.cbSupplier.Items[cbSupplier.SelectedIndex].ToString();
            this.lst_selected_item_display.Clear();
            //Remove all the supplers items from the master selected list

            do
            {
                match = lst_selected_items.Find(
                    delegate(sales_item tmp)
                    {
                        return tmp.vendor_code == vendor;
                    }
                );
                if (match.vendor_code != null)
                    lst_selected_items.Remove(match);
            } while (match.item_name != null);

            if (this.lst_display_items.Count == 1)
            {
                //Only 1 item here, probably the "ALL" option
                this.add_item(lst_display_items[0]);
            }
            else
            {
                foreach (sales_item an_item in lst_display_items)
                {
                    if (an_item.item_code != "ALL")
                        this.add_item(an_item);
                }
            }
            this.update_selected_item_display();
        }

        private void bRemoveItem_Click(object sender, EventArgs e)
        {
            int idx = cbSelectedItems.SelectedIndex;
            if (idx >= 0)
            {
                sales_item removeme = (sales_item)cbSelectedItems.Items[idx];
                lst_selected_items.Remove(removeme);
                this.update_selected_item_display();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbItemImport.Text.Length < 1)
                return;
            sales_item match;

//            MessageBox.Show("Importing Items");
            string[] items = tbItemImport.Text.Split(',');
            foreach (string an_item in items)
            {
                            //Finally, look for the item number (always unique) and add it if its not there
                match = this.lst_display_items.FirstOrDefault(
                delegate(sales_item tmp)
                {
                    return tmp.item_code == an_item;
                });
                if (match.item_code == null)
                {
                    MessageBox.Show("Item " + an_item + "Not found for this supplier, skipped");
                } else {

                    add_item(match);
                }
            }
            this.update_selected_item_display();
        }

        private void tbItemImport_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
    }


}
