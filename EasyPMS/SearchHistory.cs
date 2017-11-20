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
    public partial class SearchHistory : Form
    {
        public SearchHistory()
        {
            InitializeComponent();
        }

        int cIndex = 0;
        int[] indecies;

        private void SearchHistory_Load(object sender, EventArgs e)
        {
        }

        private void chromeButton1_Click(object sender, EventArgs e)
        {
            cIndex = 0;
            string bName = null;
            string pName = null;
            string d = null;
            if (txtBox1.Text.Length > 0)
                bName = txtBox1.Text;
            if (prodName.Text.Length > 0)
                pName = prodName.Text;
            if (chromeCheckbox1.Checked)
                d = dateTimePicker1.Value.ToShortDateString();

            indecies = ((ShopManager)Owner).GetHistoryItemIndices(bName, pName, d);
            if (indecies.Length > 0)
            {
                ((ShopManager)Owner).ScrollToHistoryItem(indecies[cIndex]);
            }
            else
                Utils.InfoMsg("Watch out!", "There seems not to be any items related with your search.");
        }

        private void chromeButton2_Click(object sender, EventArgs e)
        {
            cIndex++;
            if (cIndex >= indecies.Length)
            {
                Utils.InfoMsg("Watch out!", "There are no more available results for this search.");
                return;
            }
            ((ShopManager)Owner).ScrollToHistoryItem(indecies[cIndex]);
        }

        private void chromeCheckbox1_CheckedChanged(object sender)
        {
            dateTimePicker1.Enabled = chromeCheckbox1.Checked;
        }
    }
}
