using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace EasyPMS
{
    public partial class AccountToolbox : Form
    {
        Dictionary<string, Shop> shps;
        Account acc;
        public AccountToolbox(Account a)
        {
            InitializeComponent();
            acc = a;
            shps = new Dictionary<string, Shop>();
            foreach (var v in acc.Shops)
                shps.Add(v.Name, v);
        }

        private void UpdateUI()
        {
            // Load total revenues...
            Series ss = new Series();
            //ss.Palette = ChartColorPalette.Bright;
            ss.ChartType = SeriesChartType.Pie;
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart1.Series.Add(ss);
            listBox1.Items.Clear();
            foreach (var s in shps)
            {
                DataPoint dp = new DataPoint(0.0, s.Value.GetCurrentRevenue());
                dp.Label = s.Value.Name;
                chart1.Series[0].Points.Add(dp);
            }

            // Time to load the monthly profits
            foreach (var s in shps)
            {
                // Create a new series for the current shop.
                Series series = new Series(s.Value.Name);
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 3;
                foreach (var d in s.Value.GetCurrentMonthProfits())
                {
                    series.Points.AddXY(d.Day, d.AmountSold * d.UnitPrice);
                }
                chart2.Series.Add(series);
            }

            // Load monthly revenues and sales
            float revenue = 0.0f;
            int sales = 0;
            foreach (var s in shps)
            {
                foreach (var v in s.Value.GetCurrentMonthProfits())
                {
                    revenue += v.AmountSold * v.UnitPrice;
                    sales++;
                }
            }
            mRev.Text = revenue.ToString() + " USD";
            mSales.Text = sales.ToString();
            numShops.Text = shps.Count.ToString();

            // Load every shop on the listbox.
            foreach (var s in shps)
            {
                listBox1.Items.Add(s.Value.Name);
            }
            Log.Info("UI data has been updated at " + DateTime.Now.ToString());
        }

        private void AccountToolbox_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void AccountToolbox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void buttonGreen1_Click(object sender, EventArgs e)
        {
            CreateShop cs = new CreateShop(acc.AccountName);
            cs.ShowDialog(this);
            if (cs.CreatedShop != null)
            {
                shps.Add(cs.CreatedShop.Name, cs.CreatedShop);
                UpdateUI();
            }
        }

        private void buttonBlue2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                shps.Remove(name);
                string file = Path.Combine(new string[] { Environment.CurrentDirectory, acc.FolderPath, name + "_shop.sdf" });

                if (File.Exists(Path.Combine(new string[] { Environment.CurrentDirectory, acc.FolderPath, name + "_shop.sdf" })))
                {
                    File.Delete(Path.Combine(new string[] { Environment.CurrentDirectory, acc.FolderPath, name + "_shop.sdf" }));
                }
                UpdateUI();
            }
        }

        private void buttonBlue1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DBUtils.DbSource = acc.FolderPath +"\\" + listBox1.SelectedItem.ToString() + "_shop.sdf";
                ShopManager shmp = new ShopManager(shps[listBox1.SelectedItem.ToString()]);
                shmp.ShowDialog(this);
            }
        }


    }
}
