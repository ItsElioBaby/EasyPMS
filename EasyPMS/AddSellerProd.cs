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
    public partial class AddSellerProd : Form
    {
        public AddSellerProd()
        {
            InitializeComponent();
        }

        public SellerProduct Prod = null;

        private void buttonBlue1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length == 0 || txtBox2.Text.Length == 0 || txtBox3.Text.Length == 0)
            {
                Utils.ErrorMsg("Error", "Please fill in all the necessary information.");
                return;
            }
            foreach (char c in txtBox2.Text)
            {
                if (!char.IsNumber(c) && c != '.')
                {
                    Utils.ErrorMsg("Error", "Please choose a valid number for the unit cost.");
                    return;
                }
            }
            foreach (char c in txtBox3.Text)
            {
                if (!char.IsNumber(c) && c != '.')
                {
                    Utils.ErrorMsg("Error", "Please choose a valid number for the unit price.");
                    return;
                }
            }

            float uc = Math.Abs(float.Parse(txtBox2.Text));
            float up = Math.Abs(float.Parse(txtBox3.Text));

            Prod = new SellerProduct(txtBox1.Text, up, uc, 0, 0);
            this.Close();
        }
    }
}
