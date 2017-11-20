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
    public partial class AddSEProd : Form
    {
        public AddSEProd()
        {
            InitializeComponent();
        }

        public SEProduct Prod = null;

        private void buttonBlue1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length == 0 || txtBox2.Text.Length == 0 || txtBox3.Text.Length == 0)
            {
                Utils.ErrorMsg("Error", "Please fill in all the necessary information.");
                return;
            }
            foreach (char c in txtBox2.Text)
            {
                if (!char.IsNumber(c))
                {
                    Utils.ErrorMsg("Error", "Please choose a valid percentage for this product.");
                    return;
                }
            }
            foreach (char c in txtBox3.Text)
            {
                if (!char.IsNumber(c))
                {
                    Utils.ErrorMsg("Error", "Please choose a valid double-dip percentage for this product.");
                    return;
                }
            }

            int percentage = Math.Abs(int.Parse(txtBox2.Text));
            int ddpercentage = Math.Abs(int.Parse(txtBox3.Text));
            Prod = new SEProduct(txtBox1.Text, percentage, ddpercentage);
            this.Close();
        }
    }
}
