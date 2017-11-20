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
    public partial class AddQueueItem : Form
    {
        int percentage = 0;

        public ProductQueue Product;

        public AddQueueItem()
        {
            InitializeComponent();
        }

        private void AddQueueItem_Load(object sender, EventArgs e)
        {
            foreach (var v in ((ShopManager)Owner).shop.SEProducts)
                seTypes.Items.Add(v.Name);
            seTypes.SelectedIndex = 0;
            chromeRadioButton1.Checked = true;
            percentage = ((ShopManager)Owner).shop.SEProducts.Find(x => {
                if (x.Name == seTypes.SelectedItem.ToString())
                    return true;
                return false;
            }).Percentage;
        }

        bool IsNumber(string txt)
        {
            foreach (char c in txt)
            {
                if (!char.IsNumber(c) && c != '.')
                    return false;
            }
            return true;
        }

        private void buttonBlue1_Click(object sender, EventArgs e)
        {
            if (clientName.Text.Length > 0 && prodName.Text.Length > 0 && initialPrice.Text.Length > 0 && IsNumber(initialPrice.Text))
            {
                Product = new ProductQueue(prodName.Text, clientName.Text, dateAdded.Value.ToString("dd/MM/yyy"), percentage, float.Parse(initialPrice.Text), (float)((float.Parse(initialPrice.Text) * (float)percentage) / (float)100));
                this.Close();
            }
            else
                Utils.ErrorMsg("Error", "Please fill in correctly the desired items.");
        }

        private void chromeRadioButton1_CheckedChanged(object sender)
        {
            percentage = ((ShopManager)Owner).shop.SEProducts.Find(x =>
            {
                if (x.Name == seTypes.SelectedItem.ToString())
                    return true;
                return false;
            }).Percentage;
        }

        private void chromeRadioButton2_CheckedChanged(object sender)
        {
            percentage = ((ShopManager)Owner).shop.SEProducts.Find(x =>
            {
                if (x.Name == seTypes.SelectedItem.ToString())
                    return true;
                return false;
            }).DoubleDipPercentage;
        }
    }
}
