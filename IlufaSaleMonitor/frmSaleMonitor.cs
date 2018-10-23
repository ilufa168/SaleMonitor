using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IlufaSharedObjects;
using WaitingBox;

namespace IlufaSaleMonitor
{
    public partial class frmSaleMonitor : Form
    {
        List<Sale> all_sales = new List<Sale>();
        List<Sale> filterd_sales = new List<Sale>();
        BindingList<_Sale> display_sales = new BindingList<_Sale>();
        public frmSaleMonitor()
        {
            InitializeComponent();
            _SaleDataGridView.EnableHeadersVisualStyles = false;
            _SaleDataGridView.RowHeadersDefaultCellStyle.Font = new Font("Arial", 12f, FontStyle.Italic);
        }

        private void frmSaleMonitor_Load(object sender, EventArgs e)
        {
            //Load in all the sales
            ShowWaitingBox waiting = new ShowWaitingBox("Loading Your Sales", "This may be fast or may be slow depending on the geothermal temperature of Saturn.");
            waiting.Start();

            all_sales = Sale.loadAllSales();

            waiting.Stop();

            if (all_sales==null)
            { 
                MessageBox.Show("No sales retrieved.  Unless you have never set up any sales, check your database connection");
                return;
            }

            this.displaySales();

        }

        private void processFilters()
        {
            //1st filter for current/expired/etc
            System.Collections.Generic.IEnumerable<Sale> tmp;
            if (all_sales == null) return;
            if (all_sales.Count() == 0)
                return;

            if (rbActive.Checked)
            {
                tmp = from ll in all_sales
                          where DateTime.Now > ll.get_start_date()
                           && DateTime.Now < ll.get_end_date()
                          select ll;
            } else if (rbExpired.Checked)
            {
                tmp = from ll in all_sales
                          where DateTime.Now > ll.get_end_date()
                          select ll;
            }
            else  //only upcoming left
            {
                tmp = from ll in all_sales
                          where DateTime.Now < ll.get_start_date()
                          select ll;
            }

            filterd_sales = tmp.ToList<Sale>();

            if (tbSupplierFilter.Text.Length > 0)
            {
                string search_for_me = tbSupplierFilter.Text;
                tmp = from ll in filterd_sales
                      where ll.getSupplierString().Contains(search_for_me)
                      select ll;
                filterd_sales = tmp.ToList<Sale>();
            }

            if (tbItemFilter.Text.Length > 0)
            {
                tmp = from ll in filterd_sales
                      where ll.getItemString().Contains(tbItemFilter.Text)
                      select ll;
                filterd_sales = tmp.ToList<Sale>();
            }


        }

        private void displaySales()
        {
            //Process filters
            this.processFilters();
            //now set up the display binding list
            display_sales = new BindingList<_Sale>();
            foreach (Sale a_sale in filterd_sales)
            {
                display_sales.Add(a_sale.MakeBindingListItem());
            }

            //Now add it to the sale binding source
            _SaleBindingSource.DataSource = display_sales;
            _SaleDataGridView.Refresh();
        }

        private void rbActive_Click(object sender, EventArgs e)
        {
            this.displaySales();
        }

        private void rbUpcoming_Click(object sender, EventArgs e)
        {
            this.displaySales();
        }

        private void rbExpired_Click(object sender, EventArgs e)
        {
            this.displaySales();
        }

        private void _SaleDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //If the user double clicks a row, bring up the edit winsow
            //First get the sale id
            _Sale clicked_sale = (_Sale) _SaleDataGridView.Rows[e.RowIndex].DataBoundItem;
            var the_sale = from ll in all_sales
                            where ll.get_sale_id() == clicked_sale.sale_id
                            select ll;

            if (!(the_sale.Count() == 1))
            {
                //Somehow we got too many rows
                MessageBox.Show("Something went wrong, please try again");
            }

        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            this.displaySales();
        }

        private void editSale(Sale the_sale)
        {
            //Launch an edit sale window (dialog box)? 
            //MessageBox.Show("Edit Sale sale id =" + the_sale.get_sale_id());
            DialogResult result;
            switch (the_sale.get_sale_type()){
                case 1:
                    
                    frmAddEditPctDiscount f_edit_sale = new frmAddEditPctDiscount((PercentDiscountSale) the_sale);
                    result = f_edit_sale.ShowDialog();
                    frmSaleMonitor_Load(this, new EventArgs());
                    break;
                case 2:
                    frmAddEditFixedAmount f_edit_fix_sale = new frmAddEditFixedAmount((FixedAmountSale) the_sale);
                    result = f_edit_fix_sale.ShowDialog();
                    frmSaleMonitor_Load(this, new EventArgs());
                    break;
                case 3:
                    FrmAddEditBuyXforRP f_edit_xFor_sale = new FrmAddEditBuyXforRP((BuyXForPrice)the_sale);
                    result = f_edit_xFor_sale.ShowDialog();
                    frmSaleMonitor_Load(this, new EventArgs());
                    break;
                case 4:
                    frmAddEditFixedAmount f_edit_fix_amt = new frmAddEditFixedAmount((FixedAmountSale) the_sale);
                    result = f_edit_fix_amt.ShowDialog();
                    frmSaleMonitor_Load(this, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        private void _SaleDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (_SaleDataGridView.SelectedRows.Count == 0)
                return;

            _Sale the_sale = (_Sale) _SaleDataGridView.Rows[_SaleDataGridView.SelectedRows[0].Index].DataBoundItem;

            this.editSale(PercentDiscountSale.FetchASale(all_sales,the_sale.sale_id));
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            //Open window to choose sale type
            frmPickNewSale w_pick_sale = new frmPickNewSale();
            Sale new_sale = new Sale();
            DialogResult result = w_pick_sale.ShowDialog();

            if (result == DialogResult.OK)
            {
                int sale_type = w_pick_sale.getSelectedSaleType();
                switch (sale_type)
                {
                    case 1:
                        new_sale = new PercentDiscountSale();
                        new_sale.set_sale_type(1);
                        this.editSale(new_sale);
                        break;
                    case 2:
                        FixedAmountSale new_fix_sale = new FixedAmountSale();
                        new_fix_sale.set_sale_type(2);
                        this.editSale(new_fix_sale);
                        break;
                    case 3:
                        BuyXForPrice new_xFor_sale = new BuyXForPrice();
                        new_xFor_sale.set_sale_type(3);
                        this.editSale(new_xFor_sale);
                        break;
                    case 4:
                        FixedAmountSale new_fixed_amt_sale = new FixedAmountSale();
                        new_fixed_amt_sale.set_sale_type(4);
                        this.editSale(new_fixed_amt_sale);
                        break;
                    default:
                        MessageBox.Show("Unknown sale type, this should not happen.  Contact support.");
                        break;
                }
                
                //Add dialog box to get a sale type

            }
        }


        private void bEdit_Click_1(object sender, EventArgs e)
        {
            if (_SaleDataGridView.SelectedRows.Count == 0)
                return;

            _Sale the_sale = (_Sale)_SaleDataGridView.Rows[_SaleDataGridView.SelectedRows[0].Index].DataBoundItem;

            this.editSale(Sale.FetchASale(all_sales, the_sale.sale_id));

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            _Sale the_sale = (_Sale)_SaleDataGridView.Rows[_SaleDataGridView.SelectedRows[0].Index].DataBoundItem;

            if (the_sale.sale_id > 0)
            {
                if (Sale.delete_sale(the_sale.sale_id))
                {
                    MessageBox.Show("Sale [" + the_sale.sale_id.ToString() + "] deleted.");
                    frmSaleMonitor_Load(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Error Error, sale not deleted");
                }
            }
            //MessageBox.Show("Not implemented yet");
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");
        }

        private void tbSupplierFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== 13)
                this.displaySales();

        }

        private void tbItemFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.displaySales();
        }
    }
}
