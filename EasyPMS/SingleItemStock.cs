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
    public partial class SingleItemStock : Form
    {
        string[] typs;

        public StockProduct Prod;

        public SingleItemStock(string[] types)
        {
            InitializeComponent();
            
            typs = types;
        }

        private void SingleItemStock_Load(object sender, EventArgs e)
        {
            dropDownComboBox1.Items.AddRange(typs);
            dropDownComboBox1.SelectedIndex = 0;
        }

        private void buttonBlue1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length == 0)
            {
                Utils.ErrorMsg("Error", "Please enter a valid item data.");
                return;
            }
            Prod = new StockProduct(txtBox1.Text, dropDownComboBox1.SelectedItem.ToString());
            this.Close();
        }
    }
}
