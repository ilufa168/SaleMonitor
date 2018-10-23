using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IlufaSharedObjects;


namespace IlufaSaleMonitor
{
//    struct sale_source_type
//    {
//        public int sale_source_id;
//        public string sale_description;
//
//        public override string ToString() { return sale_description; }
//    }

    struct sale_type
    {
        public int sale_type_id;
        public string sale_type_description;

        public override string ToString()
        {
            return sale_type_description;
        }
    }

    struct supplier
    {
        public string supplier_id;
        public string supplier_name;
    }

    struct codes
    {
        public string code;
        public string code_description;

        public override string ToString()
        {
            return code + "-" + code_description;
        }
    }

/*    public struct item
    {
        public string item_code;
        public string item_name; ///////////////////////////moved to sale.cs where its needed
        public string vendor_code;

        public override string ToString()
        {
            return item_code + " -- " + item_name;
        }
    }
*/
    public partial class IlufaSameMonitor : Form
    {
        List<_Sale> current_sales;
        List<_Sale> expired_sales;
        List<_Sale> future_sales;

        public IlufaSameMonitor()
        {
            this.current_sales = new List<_Sale>();
            this.expired_sales = new List<_Sale>();
            InitializeComponent();
        }

        private void bNewSale_Click(object sender, EventArgs e)
        {
            //Open a new sale window in dialog mode
            frmNewSale fSaleWindow = new frmNewSale();

            DialogResult dr=fSaleWindow.ShowDialog();

            this.refresh_sales();
        }

        private List<_Sale> load_a_sale(string type)
        {
            List<_Sale> the_list = new List<_Sale>();
            List<Sale> tmp_list;

            switch (type)
            {
                case "C": //current
                     tmp_list = Sale.load_current();
                     break;
                case "E":
                     tmp_list = Sale.load_expired();
                     break;
                case "F":
                     tmp_list = Sale.load_future();
                     break;
                default:
                    return the_list;
            }

            foreach (Sale a_sale in tmp_list)
            {
                _Sale for_display = new _Sale(a_sale.get_sale_id(),a_sale.get_start_date(), a_sale.get_end_date(),
                                              a_sale.get_sale_type().ToString(),
                                              a_sale.get_sale_source_type().ToString(),
                                              a_sale.display_parameters());
                the_list.Add(for_display);
            }

            return the_list;
        }

        private void refresh_sales()
        {
            current_sales = load_a_sale("C");
            dgCurrentSales.DataSource = current_sales;
            //Now load the expired
            expired_sales = load_a_sale("E");
            dgExpiredSales.DataSource = expired_sales;
            //Finally the future
            future_sales = load_a_sale("F");
            dgFutureSales.DataSource = future_sales;
            dgCurrentSales.Refresh();
            dgExpiredSales.Refresh();
            dgFutureSales.Refresh();

        }
        private void IlufaSameMonitor_Load(object sender, EventArgs e)
        {
            this.refresh_sales();
            
//            dgCurrentSales.Hide();
//            dgCurrentSales.Show();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string id = "";

            if (tabSales.SelectedTab.Name == "tabPage1")
            {
                if (dgCurrentSales.SelectedRows.Count > 0)
                    id = dgCurrentSales.Rows[dgCurrentSales.SelectedRows[0].Index].Cells[0].Value.ToString();                                    
            } else 
            if (tabSales.SelectedTab.Name == "tabPage2")
            {
                if (dgFutureSales.SelectedRows.Count > 0)
                    id = dgFutureSales.Rows[dgFutureSales.SelectedRows[0].Index].Cells[0].Value.ToString();    
            } else 
            if (tabSales.SelectedTab.Name == "tabPage3")
            {
                if (dgExpiredSales.SelectedRows.Count > 0)
                    id = dgExpiredSales.Rows[dgExpiredSales.SelectedRows[0].Index].Cells[0].Value.ToString();    
            }

            if (id == "")
                return;

            DialogResult result1 = MessageBox.Show("Are you sure you want to delete the Sale with id #" + id + ". It will be gone forevermore.",
                         "Important Question",
                         MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                if (Sale.delete_sale(int.Parse(id)))
                    MessageBox.Show("Sale Deleted");
                //Send a call to sale static delete function
            }

            this.refresh_sales();
            return;




        }

        private void bBuyXYFree_Click(object sender, EventArgs e)
        {
            //Open a new sale window in dialog mode
            frmNewBuyXGetYFree fSaleWindow = new frmNewBuyXGetYFree();

            DialogResult dr = fSaleWindow.ShowDialog();

            this.refresh_sales();
        }

        private void dgCurrentSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
