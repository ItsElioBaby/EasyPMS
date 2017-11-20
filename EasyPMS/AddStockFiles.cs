using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EasyPMS
{
    public partial class AddStockFiles : Form
    {
        string[] data;

        public List<StockProduct> Stock;

        string[] types;

        public AddStockFiles(string f, string[] typs)
        {
            InitializeComponent();
            data = File.ReadAllLines(f);
            if (data.Length == 0)
            {
                Utils.ErrorMsg("Error", "The file you've choosen seems invalid.");
                return;
            }
            Stock = new List<StockProduct>();
            if (typs.Length == 0 || typs == null)
            {
                Utils.ErrorMsg("Error", "Please make sure you've created at least one product type before proceeding.");
                return;
            }
            types = typs;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void AddStockFiles_Load(object sender, EventArgs e)
        {
            // Get every possible line.
            foreach (string line in data)
            {
                if (line.StartsWith("//", StringComparison.CurrentCulture))
                    continue;  // It's a comment.
                if (line.Split(':').Length == 1)
                    continue;  // Not valid.
                listBox1.Items.Add(line);
            }
            dropDownComboBox1.Items.AddRange(types);
            dropDownComboBox1.SelectedIndex = 0;
        }

        private void buttonBlue1_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.Items)
            {
                Stock.Add(new StockProduct(s, dropDownComboBox1.SelectedItem.ToString()));
            }
            this.Close();
        }
    }
}
