using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyPMS
{
    public partial class CreateShop : Form
    {
        string acc_name;

        public CreateShop(string name)
        {
            InitializeComponent();
            acc_name = name;
        }

        private Shop s;
        private ShopType type = ShopType.Seller;

        public Shop CreatedShop { get { return s; } }

        private void buttonGreen1_Click(object sender, EventArgs e)
        {
            s = new Shop(txtBox1.Text, type, new SellerProduct[] { }, new SEProduct[] { }, new HistoryProduct[] { }, new ProductQueue[] { }, new StockProduct[] { });
            DBUtils.CreateNewShop(s, acc_name);
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                type = ShopType.Seller;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                type = ShopType.SocialEngineer;
        }
    }
}
