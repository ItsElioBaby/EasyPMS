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
    public partial class SearchItems : Form
    {
        int searchType = 0;  // Stock items

        int cIndex = 0;

        int[] foundIndices;

        public SearchItems()
        {
            InitializeComponent();
        }

        private void chromeButton1_Click(object sender, EventArgs e)
        {
            cIndex = 0;
            if (txtBox1.Text.Length > 0)
            {
                if (searchType == 0)
                {
                    foundIndices = ((ShopManager)this.Owner).GetStockItemIndices(txtBox1.Text);
                    if (foundIndices.Length == 0)
                    {
                        Utils.InfoMsg("Watch out!", "No matches for your search!");
                        return;
                    }
                    ((ShopManager)this.Owner).ScrollToStockItem(foundIndices[0]);
                }
                if (searchType == 1)
                {
                    foundIndices = ((ShopManager)this.Owner).GetProductTypeIndices(txtBox1.Text);
                    if (foundIndices.Length == 0)
                    {
                        Utils.InfoMsg("Watch out!", "No matches for your search!");
                        return;
                    }
                    ((ShopManager)this.Owner).ScrollToProductType(foundIndices[0]);
                }
            }
        }

        private void chromeRadioButton1_CheckedChanged(object sender)
        {
            if (chromeRadioButton1.Checked)
                searchType = 0;
        }

        private void chromeRadioButton2_CheckedChanged(object sender)
        {
            if (chromeRadioButton2.Checked)
                searchType = 1;
        }

        private void chromeButton2_Click(object sender, EventArgs e)
        {
            cIndex++;
            if (cIndex < foundIndices.Length)
            {
                if (searchType == 0)
                {
                    ((ShopManager)this.Owner).ScrollToStockItem(foundIndices[cIndex]);
                }
                if (searchType == 1)
                {
                    ((ShopManager)this.Owner).ScrollToProductType(foundIndices[cIndex]);
                }
            }
            else
                Utils.InfoMsg("Watch out!", "No more matches for your search.");
        }
    }
}
