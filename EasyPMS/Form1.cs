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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBlue1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox1.Text) && !string.IsNullOrWhiteSpace(txtBox1.Text)
                && !string.IsNullOrWhiteSpace(txtBox2.Text) && !string.IsNullOrEmpty(txtBox2.Text))
            {
                Account acc = new Account(txtBox1.Text, txtBox2.Text, false);
                acc.Save(new Random().Next() + ".epms");
                AccountToolbox act = new AccountToolbox(acc);
                act.Show(this);
                this.Hide();
            }
        }

        List<Account> accs = new List<Account>();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var f in Directory.GetFiles(Environment.CurrentDirectory))
            {
                if (Path.GetExtension(f) == ".epms")
                    accs.Add(Account.FromFile(f));
            }
            foreach (var v in accs)
                dropDownComboBox1.Items.Add(v.AccountName);
            if(accs.Count > 0)
                dropDownComboBox1.SelectedIndex = 0;
        }

        private void buttonGreen1_Click(object sender, EventArgs e)
        {
            if (accs.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtBox3.Text) && !string.IsNullOrWhiteSpace(txtBox3.Text))
                {
                    for (int i = 0; i < accs.Count; i++)
                    {
                        if (accs[i].AccountName == dropDownComboBox1.SelectedItem.ToString())
                        {
                            if (accs[i].AccountPasswordHash == Utils.MD5Hash_64(txtBox3.Text))
                            {
                                AccountToolbox act = new AccountToolbox(accs[i]);
                                act.Show(this);
                                this.Hide();
                            }
                            else
                                Utils.ErrorMsg("Error", "The password you've entered doesn't match the one associated with this account.");
                        }
                    }
                }
            }
        }

        private void txtBox3_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
