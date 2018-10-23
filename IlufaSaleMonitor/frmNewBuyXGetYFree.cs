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
    public partial class frmNewBuyXGetYFree : Form
    {
        BindingList<sales_item> lst_x_items = new BindingList<sales_item>();
        BindingList<sales_item> lst_y_items = new BindingList<sales_item>();
        public frmNewBuyXGetYFree()
        {
            InitializeComponent();
        }

        private void frmNewBuyXGetYFree_Load(object sender, EventArgs e)
        {
            lst_x_items = new BindingList<sales_item>();
            lst_y_items = new BindingList<sales_item>();

            cbXItems.DataSource = lst_x_items;
            cbYItems.DataSource = lst_y_items;
        }

        private void cbXItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //First some code to parse seperate the commas, then for each
                //Some code to validate and create a sale item
                if (cbXItems.Text.Length > 0)
                {
                    string[] items = cbXItems.Text.Split(',');
                    List<sales_item> lst_si = parse_and_add(items);
                    foreach (sales_item an_item in lst_si)
                    {
                        //Verify the item is not in the list
                        sales_item match = this.lst_x_items.FirstOrDefault(
                            delegate(sales_item tmp)
                            {
                                return tmp.item_code == an_item.item_code;
                            });
                            if (match.item_code == null)
                            {
                                lst_x_items.Add(an_item);
                            }

                    }
                    cbXItems.Text = "";
                    e.Handled = true;
                }
            }
            
             
        }

        private List<sales_item> parse_and_add(string[] items)
        {
            List<sales_item> lst_si = new List<sales_item>();

            foreach (string an_item in items)
            {
                //Make sure the item is not already in the list
                sales_item tmp_si = Sale.load_an_item(an_item);
                if (tmp_si.item_code != "NOT FOUND")
                   lst_si.Add(tmp_si);
            }

            return lst_si;
        }

        private void cbYItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //First some code to parse seperate the commas, then for each
                //Some code to validate and create a sale item
                if (cbYItems.Text.Length > 0)
                {
                    string[] items = cbYItems.Text.Split(',');
                    List<sales_item> lst_si = parse_and_add(items);
                    foreach (sales_item an_item in lst_si)
                    {
                        //Verify the item is not in the list
                        sales_item match = this.lst_y_items.FirstOrDefault(
                            delegate(sales_item tmp)
                            {
                                return tmp.item_code == an_item.item_code;
                            });
                        if (match.item_code == null)
                        {
                            lst_y_items.Add(an_item);
                        }

                    }
                    cbXItems.Text = "";
                    e.Handled = true;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> error_messages = new List<string>(); 
            bool errors = false;

            if (snbX.Text.Length == 0 || snbY.Text.Length == 0)
            {
                errors = true;
                error_messages.Add("Enter a number for the X and Y Values");
            }
            if (snbDiscount.Text.Length == 0)
            {
                errors = true;
                error_messages.Add("Enter a discount percentage value");
            }
            try
            {
                int iDiscount = int.Parse(snbDiscount.Text);
                if (iDiscount < 1 || iDiscount > 100)
                {
                    errors = true;
                    error_messages.Add("Discount percentage must be between 1 and 100");
                }
            }
            catch(Exception ex)
            {
                errors = true;
                error_messages.Add("Discount percentage must be between 1 and 100 : " + ex.Message);
  
            }
            finally
            {
//                errors = true;
//                error_messages.Add("Discount percentage must be between 1 and 100");
            }
            if (lst_x_items.Count == 0 || lst_y_items.Count == 0)
            {
                errors = true;
                error_messages.Add("At least 1 X and Y item code is required");
            }

            if (!errors)
                errors = save_sale();

            if (!errors)
            {
                MessageBox.Show("Sale added");
                DialogResult = DialogResult.OK;
            }
            else
            {

                string error_text = "";
                foreach (string msg in error_messages)
                {
                    error_text = error_text + msg + "\n";
                }
                MessageBox.Show(error_text);
            }
        }

        private bool save_sale()
        {
            bool errors = false;

            BuyXGetYFreeSale a_sale = new BuyXGetYFreeSale();

            a_sale.set_x_list(lst_x_items.ToList());
            a_sale.set_y_list(lst_y_items.ToList());
            a_sale.set_xy(int.Parse(this.snbX.Text), int.Parse(this.snbY.Text));
            a_sale.set_start_date(this.monthStart.SelectionStart);
            a_sale.set_end_date(this.monthEnd.SelectionStart);
            a_sale.set_sale_source_type(2);
            a_sale.set_sale_type(2);
            a_sale.set_discount_value(double.Parse(snbDiscount.Text));
            if (!a_sale.save())
                errors = true;

            return errors;
        }
 
    }
}
