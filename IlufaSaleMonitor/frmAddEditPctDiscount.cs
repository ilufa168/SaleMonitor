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
    public partial class frmAddEditPctDiscount : frmAddEditSaleBase
    {
        //Sale the_sale = new PercentDiscountSale();

        public frmAddEditPctDiscount()
        {
            InitializeComponent();
        }

        public frmAddEditPctDiscount(PercentDiscountSale a_sale)
        {
            edit_mode = true;
            this.the_sale = a_sale;
            InitializeComponent();
        }

        protected override void initForDiscount()
        {
            setSaleTypeDD(0);
//            pBuyXGetY.Enabled = false;
//            pBuyXGetY.Visible = false;
            pPercentDiscount.Enabled = true;
            pPercentDiscount.Visible = true;
            //Its a percent discount sale so cast it properly
            nbDiscPct.Value = (decimal)the_sale.get_discount_value();
            this.BuildItemTreePctDisc();
            rtbCurrentItems.Text = the_sale.display_parameters();
        }

    }
}
