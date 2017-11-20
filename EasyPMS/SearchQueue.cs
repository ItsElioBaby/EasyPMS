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
    public partial class SearchQueue : Form
    {
        int[] indicies;
        int cIndex = 0;

        public SearchQueue()
        {
            InitializeComponent();
        }

        private void chromeCheckbox1_CheckedChanged(object sender)
        {
            dateTimePicker1.Enabled = chromeCheckbox1.Checked;
        }

        private void chromeButton1_Click(object sender, EventArgs e)
        {
            cIndex = 0;
            string bName = null,
                pName = null,
                d = null;
            if (txtBox1.Text.Length > 0)
                bName = txtBox1.Text;
            if (prodName.Text.Length > 0)
                pName = prodName.Text;
            if (chromeCheckbox1.Checked)
                d = dateTimePicker1.Value.ToShortDateString();
            indicies = ((ShopManager)Owner).GetQueueItemIndices(bName, pName, d);
            if (indicies.Length > 0)
            {
                ((ShopManager)Owner).ScrollToQueueItem(cIndex);
            }
            else
                Utils.InfoMsg("Watch out!", "There were no results for your search.");
        }

        private void chromeButton2_Click(object sender, EventArgs e)
        {
            cIndex++;
            if (indicies.Length <= cIndex)
            {
                Utils.InfoMsg("Watch out!", "There are no more results for this search!");
                return;
            }
            ((ShopManager)Owner).ScrollToQueueItem(cIndex);
        }
    }
}
