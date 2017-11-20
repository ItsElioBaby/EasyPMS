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
    public partial class CompleteQueue : Form
    {
        ProductQueue pq;
        public HistoryProduct hp;

        public CompleteQueue(ProductQueue pq)
        {
            InitializeComponent();
            this.pq = pq;
        }


        private HistoryProduct QueueToHistory(ProductQueue prod, string summary)
        {
            HistoryProduct hp = new HistoryProduct(prod.ProductName, prod.ClientName, (prod.InitialPrice * (float)prod.Percentage) / 100.0f, DateTime.Now.ToString("dd/MM/yyy"), 1, summary);
            return hp;
        }

        private void CompleteQueue_Load(object sender, EventArgs e)
        {
            cName.Text = pq.ClientName;
            pName.Text = pq.ProductName;
            pPrice.Text = pq.InitialPrice.ToString();
            percent.Text = pq.Percentage.ToString();
            fPrice.Text = ((pq.InitialPrice * (float)pq.Percentage) / 100.0f).ToString();
        }

        private void buttonGreen1_Click(object sender, EventArgs e)
        {
            hp = QueueToHistory(pq, textBox1.Text);
            this.Close();
        }
    }
}
