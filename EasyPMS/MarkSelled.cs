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
    public partial class MarkSelled : Form
    {
        StockProduct[] products;
        Dictionary<string, HistoryProduct> hps = new Dictionary<string, HistoryProduct>();
        Shop shop;

        public bool Done = false;

        public MarkSelled(StockProduct[] prods)
        {
            InitializeComponent();
            products = prods;
        }

        private HistoryProduct ConvertStockToHistory(StockProduct prod, string bname)
        {
            SellerProduct sp = shop.GetSellerProduct(prod.ProductType);
            if (sp == null)
                return null;
            HistoryProduct hp = new HistoryProduct(sp.Name, bname, sp.UnitPrice, DateTime.Now.ToShortDateString(), 1, "");
            return hp;
        }

        private void MarkSelled_Load(object sender, EventArgs e)
        {
            shop = ((ShopManager)this.Owner).shop;
            foreach (var v in products)
            {
                listBox1.Items.Add(v.Value);
            }
            float amount = 0.0f;
            foreach (var v in products)
            {
                HistoryProduct hp = ConvertStockToHistory(v, "");  //pseudo history items just to calculate the total amount
                hps.Add(v.Value, hp);
                amount += hp.PriceUnit;
            }
            t_amount.Text = amount.ToString();
        }

        private void buttonGreen1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length == 0)
            {
                Utils.ErrorMsg("Error", "Please assign a buyer name.");
                return;
            }

            StringBuilder str = new StringBuilder();
            foreach(var p in products)
            {
                str.AppendLine(p.Value);
            }
            Clipboard.SetText(str.ToString());
            if(Utils.InfoMsg2("Hey", "The contents that you are selling have been copied on your clipboard therefore are ready for you to paste them to the buyer. Do you wish to save the contents in a text file too?") == DialogResult.Yes)
            {
                SaveFileDialog svg = new SaveFileDialog() { Title = "Save your contents...", Filter = "Text File *.txt|*.txt" };
                svg.ShowDialog();
                if (svg.FileName != null)
                    System.IO.File.WriteAllText(svg.FileName, str.ToString());
            }

            foreach (var v in hps)
            {
                v.Value.BuyerName = txtBox1.Text;
                v.Value.Summary = (summary.Text.Length > 0 ? summary.Text : "");
                ((ShopManager)Owner).shop.AddHistoryItem(v.Value);
            }
            Done = true;
            this.Close();
        }

        private void buttonGreen2_Click(object sender, EventArgs e)
        {
            Done = false;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox2.Text = hps[listBox1.SelectedItem.ToString()].PriceUnit.ToString();
            float amount = 0.0f;
            foreach (var v in hps.Values)
                amount += v.PriceUnit;
            t_amount.Text = amount.ToString();
        }

        private bool IsNumber(string txt)
        {
            float val;
            return float.TryParse(txt, out val);
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtBox2.Text.Length == 0 || !IsNumber(txtBox2.Text))
            {
                if (listBox1.SelectedItem != null)
                {
                    hps[listBox1.SelectedItem.ToString()].PriceUnit = ((ShopManager)Owner).shop.SellerProducts.Find(x => { if (x.Name == products[0].ProductType)return true; else return false; }).UnitPrice;
                }
            }
            else
            {
                if(listBox1.SelectedItem != null)
                {
                    if (IsNumber(txtBox2.Text))
                    {
                        hps[listBox1.SelectedItem.ToString()].PriceUnit = float.Parse(txtBox2.Text);
                    }
                }
            }
        }
    }
}
