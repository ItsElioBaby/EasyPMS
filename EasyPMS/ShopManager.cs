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
    public partial class ShopManager : Form
    {
        public Shop shop;

        public ShopManager(Shop s)
        {
            InitializeComponent();
            shop = s;
        }

#region ManagmentFunctions
        private void UpdateSalesHistory()
        {
            chart1.Series[0].Points.Clear();
            HistoryProduct[] hist = (from i in shop.History where Utils.GetDayFromDateTime(i.Date) <= 31 && Utils.GetMonthFromDateTime(i.Date) == DateTime.Now.Month orderby Utils.GetDayFromDateTime(i.Date) ascending select i).ToArray();
            Dictionary<int, int> vals = new Dictionary<int, int>();
            for (int i = 1; i < 32; i++)
                vals.Add(i, 0);
            foreach (var h in hist)
            {
                int day = Utils.GetDayFromDateTime(h.Date);
                vals[day]++;
            }
            foreach (var p in vals)
                chart1.Series[0].Points.AddXY(p.Key, p.Value);
        }

        private void UpdateRevenueHistory()
        {
            chart2.Series.Clear();
            HistoryProduct[] hist = (from i in shop.History where Utils.GetDayFromDateTime(i.Date) <= 31 && Utils.GetMonthFromDateTime(i.Date) == DateTime.Now.Month orderby Utils.GetDayFromDateTime(i.Date) ascending select i).ToArray();
            Dictionary<string, Dictionary<int, double>> vals = new Dictionary<string, Dictionary<int, double>>();
            foreach (var h in hist)
            {
                // Add every type of product name
                if (!vals.ContainsKey(h.Name))
                    vals.Add(h.Name, new Dictionary<int,double>());
            }
            foreach (var s in vals.Keys)
            {
                // Build a serie for each product type
                Series serie = new Series(s);
                serie.ChartType = SeriesChartType.Line;
                serie.BorderWidth = 3;
                for (int i = 1; i < 32; i++)
                    vals[s].Add(i, 0.0);
                foreach (var h in hist)
                {
                    if (h.Name == s)
                    {
                        vals[s][Utils.GetDayFromDateTime(h.Date)] += (double)((double)h.Amount * (double)h.PriceUnit);
                    }
                }
                foreach (var k in vals[s])
                    serie.Points.AddXY((double)k.Key, k.Value);
                chart2.Series.Add(serie);
            }
        }

        private void ListProducts()
        {
            // List products for "seller" type.
            if (shop.Type == ShopType.Seller)
            {
                objectListView1.ClearObjects();
                foreach (var v in shop.SellerProducts)
                {
                    objectListView1.AddObject(v);  // safer?
                }
            }
        }

        private void ListSEProducts()
        {
            if (shop.Type == ShopType.SocialEngineer)
            {
                objectListView5.ClearObjects();
                foreach (var v in shop.SEProducts)
                {
                    objectListView5.AddObject(v);
                }
            }
        }

        private void ListQueue()
        {
            if (shop.Type == ShopType.SocialEngineer)
            {
                objectListView4.ClearObjects();
                foreach (var v in shop.Queue)
                    objectListView4.AddObject(v);
            }
        }

        private void ListStock()
        {
            if (shop.Type == ShopType.Seller)
            {
                objectListView2.ClearObjects();
                foreach (var s in shop.Stock)
                {
                    objectListView2.AddObject(s);
                }
            }
        }

        private void RemoveSelectedStocks()
        {
            if (objectListView2.SelectedObjects.Count > 0)
            {
                var iter = objectListView2.SelectedObjects.GetEnumerator();
                while (iter.MoveNext())
                {
                    StockProduct prod = (StockProduct)iter.Current;
                    // remove it from the storage
                    DBUtils.RemoveStockProduct(prod.ID);

                    // remove it from the ui
                    objectListView2.RemoveObject(prod);

                    // remove it form the memory
                    shop.Stock.Remove(prod);
                }
            }
        }

        private StockProduct[] GetSeleted()
        {
            if (objectListView2.SelectedObjects.Count > 0)
            {
                List<StockProduct> retvals = new List<StockProduct>();

                var iter = objectListView2.SelectedObjects.GetEnumerator();
                while (iter.MoveNext())
                {
                    StockProduct prod = (StockProduct)iter.Current;
                    retvals.Add(prod);
                }
                return retvals.ToArray();
            }
            return null;
        }

        private void ListHistory()
        {
            //if (shop.Type == ShopType.Seller)
            //{
                objectListView3.ClearObjects();
                foreach (var h in shop.History)
                {
                    objectListView3.AddObject(h);
                }
            //}
        }

        private HistoryProduct[] GetHistory(int daysOld)
        {
            List<HistoryProduct> retvals = new List<HistoryProduct>();
            //if (shop.Type == ShopType.Seller)
            //{
                //objectListView3.ClearObjects();
                foreach (var h in shop.History)
                {
                    TimeSpan ts = DateTime.Now.Subtract(DateTime.Parse(h.Date));
                    if (ts.Days == daysOld)
                        retvals.Add(h);
                }
            //}
            return retvals.ToArray();
        }

        private ProductQueue[] GetProductQueue(int daysOld)
        {
            List<ProductQueue> retvals = new List<ProductQueue>();
            if (shop.Type == ShopType.SocialEngineer)
            {
                foreach (var pq in shop.Queue)
                {
                    TimeSpan ts = DateTime.Now.Subtract(DateTime.Parse(pq.DateAdded));
                    if (ts.Days == daysOld)
                        retvals.Add(pq);
                }
            }
            return retvals.ToArray();
        }


        private HistoryProduct[] GetHistory(int daysOld, int hoursOld)
        {
            List<HistoryProduct> retvals = new List<HistoryProduct>();
           // if (shop.Type == ShopType.Seller)
            //{
                //objectListView3.ClearObjects();
                foreach (var h in shop.History)
                {
                    TimeSpan ts = DateTime.Now.Subtract(DateTime.Parse(h.Date));
                    if (ts.Days <= daysOld && ts.Hours <= hoursOld)
                        retvals.Add(h);
                }
           // }
            return retvals.ToArray();
        }

        private void ListHistory(int daysOld)
        {
            //if (shop.Type == ShopType.Seller)
            //{
                objectListView3.ClearObjects();
                foreach (var h in shop.History)
                {
                    TimeSpan ts = DateTime.Now.Subtract(DateTime.Parse(h.Date));
                    if (ts.Days <= daysOld)
                        objectListView3.AddObject(h);
                }
           // }
        }

        private void ListHistory(string buyerName)
        {
            //if (shop.Type == ShopType.Seller)
            //{
                objectListView3.ClearObjects();
                foreach (var h in shop.History)
                {
                    if (h.BuyerName == buyerName)
                        objectListView3.AddObject(h);
                }
            //}
        }

        private void ListHistory(string productType, int f)
        {
            //if (shop.Type == ShopType.Seller)
            //{
                objectListView3.ClearObjects();
                foreach (var h in shop.History)
                {
                    if (h.Name == productType)
                        objectListView3.AddObject(h);
                }
            //}
        }

#endregion

        #region FindingFunction

        public void ScrollToHistoryItem(int index)
        {
            objectListView3.Focus();
            if (objectListView3.SelectedIndex == -1)
                objectListView3.SelectedIndex = 0;
            //objectListView3.LowLevelScroll(0, objectListView3.SelectedIndex - index);
            objectListView3.SelectedIndex = index;
            //objectListView3.LowLevelScroll(0, (int)objectListView3.Font.GetHeight() * index);
        }

        public void ScrollToStockItem(int index)
        {
            objectListView2.Focus();
            if (objectListView2.SelectedIndex == -1)
                objectListView2.SelectedIndex = 0;
            //objectListView2.LowLevelScroll(0, objectListView2.SelectedIndex - index);
            objectListView2.SelectedIndex = index;
            //objectListView2.LowLevelScroll(0, (int)objectListView2.Font.GetHeight() * index);
        }

        public void ScrollToProductType(int index)
        {
            objectListView1.Focus();
            if (objectListView1.SelectedIndex == -1)
                objectListView1.SelectedIndex = 0;
            //objectListView1.LowLevelScroll(0, objectListView1.SelectedIndex - index);
            objectListView1.SelectedIndex = index;
            //objectListView1.LowLevelScroll(0, (int)objectListView1.Font.GetHeight() * index);
        }

        public void ScrollToQueueItem(int index)
        {
            objectListView4.Focus();
            objectListView4.SelectedIndex = index;
        }

        public int[] GetStockItemIndices(string keywords)
        {
            List<int> retval = new List<int>();
            int cIndex = 0;
            var iter = objectListView2.Objects.GetEnumerator();
            while (iter.MoveNext())
            {
                StockProduct sp = (StockProduct)iter.Current;
                if (sp.Value.ToLower().Contains(keywords.ToLower()))
                    retval.Add(cIndex);
                cIndex++;
            }
            return retval.ToArray();
        }

        public int[] GetProductTypeIndices(string keywords)
        {
            List<int> retval = new List<int>();
            int cIndex = 0;
            var iter = objectListView1.Objects.GetEnumerator();
            while (iter.MoveNext())
            {
                StockProduct sp = (StockProduct)iter.Current;
                if (sp.Value.ToLower().Contains(keywords.ToLower()))
                    retval.Add(cIndex);
                cIndex++;
            }
            return retval.ToArray();
        }

        public int[] GetHistoryItemIndices(string buyerName, string productSold, string dateSold)
        {
            List<int> retval = new List<int>();
            if (objectListView3.Items.Count > 0)
            {
                int cIndex = 0;
                var iter = objectListView3.Objects.GetEnumerator();
                while (iter.MoveNext())
                {
                    HistoryProduct sp = (HistoryProduct)iter.Current;
                    if (buyerName != null)
                    {
                        if (sp.BuyerName.ToLower().Contains(buyerName.ToLower()))
                            retval.Add(cIndex);
                    }
                    if (productSold != null)
                    {
                        if (sp.Name.ToLower().Contains(productSold.ToLower()))
                            retval.Add(cIndex);
                    }
                    if (dateSold != null)
                    {
                        if (DateTime.Parse(sp.Date).CompareTo(DateTime.Parse(dateSold)) == 0)
                            retval.Add(cIndex);
                    }
                    cIndex++;
                }
            }
            return retval.ToArray();
        }

        public int[] GetQueueItemIndices(string buyerName, string productName, string dateAdded)
        {
            List<int> retval = new List<int>();
            int cIndex = 0;
            if (objectListView4.Items.Count > 0)
            {
                var iter = objectListView4.Objects.GetEnumerator();
                while (iter.MoveNext())
                {
                    ProductQueue pq = (ProductQueue)iter.Current;
                    if (buyerName != null)
                    {
                        if (pq.ClientName.ToLower().Contains(buyerName.ToLower()))
                            retval.Add(cIndex);
                    }
                    if (productName != null)
                    {
                        if (pq.ProductName.ToLower().Contains(productName.ToLower()))
                            retval.Add(cIndex);
                    }
                    if (dateAdded != null)
                    {
                        if (DateTime.Parse(pq.DateAdded).CompareTo(DateTime.Parse(dateAdded)) == 0)
                            retval.Add(cIndex);
                    }
                    cIndex++;
                }
            }
            return retval.ToArray();
        }

        #endregion

        private void ShopManager_Load(object sender, EventArgs e)
        {
            UpdateSalesHistory();
            UpdateRevenueHistory();
            if (shop.Type == ShopType.Seller)
            {
                queueToolStripMenuItem.Enabled = false;
                addSeProd.Enabled = false;
                chromeTabcontrol1.TabPages.RemoveAt(3);  // No queues for this kind of shop.
            }
            if (shop.Type == ShopType.SocialEngineer)
            {
                addSellerProd.Enabled = false;
                exportStock.Enabled = false;
                addStockItem.Enabled = false;
                searchToolstrip.Enabled = false;
                chromeTabcontrol1.TabPages.RemoveAt(1);  // no items for this kind of shop.
            }
            ListProducts();
            ListStock();
            ListHistory();
            ListSEProducts();
            ListQueue();
            this.Text = this.Text.Replace("{NAME}", shop.Name);
        }

#region ObjectListView Events

        string oName = "";
        StockProduct oProd = null;
        private void objectListView1_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            SellerProduct product = (SellerProduct)e.RowObject;
            e.Control = new TextBox();
            ((TextBox)e.Control).Bounds = e.CellBounds;
            ((TextBox)e.Control).Font = objectListView1.Font;
            ((TextBox)e.Control).Text = e.Value.ToString();
            oName = product.Name;
        }

        private void objectListView1_CellEditFinished(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            SellerProduct product = (SellerProduct)e.RowObject;
            if (oName != "")
            {
                DBUtils.EditSellerProduct(oName, product);
                for (int i = 0; i < shop.SellerProducts.Count; i++)
                {
                    if (shop.SellerProducts[i].Name == oName)
                        shop.SellerProducts[i] = product;  // Update it on memory too.
                }
            }
        }

        private void objectListView1_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            SellerProduct product = (SellerProduct)e.RowObject;
            if (product.Name == "")
                e.Cancel = true;
        }

        private void objectListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (objectListView1.SelectedObject != null)
                {
                    SellerProduct prod = (SellerProduct)objectListView1.SelectedObject;
                    // update them on memory
                    List<SellerProduct> sps = new List<SellerProduct>();
                    for (int i = 0; i < shop.SellerProducts.Count; i++)
                    {
                        if (shop.SellerProducts[i].Name == prod.Name)
                            shop.SellerProducts.RemoveAt(i);
                    }

                    // update them on storage
                    DBUtils.RemoveSellerProduct(prod.Name);

                    // remove them from the ui
                    objectListView1.RemoveObject(prod);
                }
            }
        }

        private void objectListView2_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            oProd = (StockProduct)e.RowObject;
        }

        private void objectListView2_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (oProd == null)
                e.Cancel = true;
        }

        private void objectListView2_CellEditFinished(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            StockProduct nProd = (StockProduct)e.RowObject;

            // update it on memory
            for (int i = 0; i < shop.Stock.Count; i++)
            {
                if (shop.Stock[i].ID == nProd.ID)
                    shop.Stock[i] = nProd;
            }

            // update it in the storage
            DBUtils.EditStockProduct(nProd.ID, nProd.Value);
        }

        private void objectListView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (objectListView2.SelectedObjects.Count > 0)
            {
                // Are we gonna delete it?
                if (e.KeyCode == Keys.Delete)
                {
                    RemoveSelectedStocks();
                }

                // Are we gonna add it to a fucking history item ?
                if (e.KeyCode == Keys.Add)
                {
                    StockProduct[] s = GetSeleted();

                    // generate a history item
                    MarkSelled ms = new MarkSelled(s);
                    ms.ShowDialog(this);

                    if (ms.Done)
                    {
                        RemoveSelectedStocks();
                        ListHistory();  // refresh it all
                    }
                }
            }
        }
#endregion

//#region MenuStrip & Other Events

        private void dropDownComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDownComboBox1.SelectedItem.ToString() == "Everything")
                ListHistory();
            if (dropDownComboBox1.SelectedItem.ToString() == "Today")
                ListHistory(0);
            if (dropDownComboBox1.SelectedItem.ToString() == "Last Week")
                ListHistory(7);
            if (dropDownComboBox1.SelectedItem.ToString() == "Last Month")
            {
                // this is kind of trickier
                int days = 0;
                int month = DateTime.Now.Month;
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    days = 31;
                if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
                {
                    days = 30;
                    if (month == 2)
                    {
                        if (DateTime.IsLeapYear(DateTime.Now.Year))
                            days = 29;
                        else
                            days = 28;
                    }
                }
                ListHistory(days);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSeProd_Click(object sender, EventArgs e)
        {
            AddSEProd asp = new AddSEProd();
            asp.ShowDialog(this);
            if (asp.Prod != null)
            {
                shop.AddSEProduct(asp.Prod);
                ListSEProducts();
            }
        }

        private void addSellerProd_Click(object sender, EventArgs e)
        {
            AddSellerProd asp = new AddSellerProd();
            asp.ShowDialog();
            if (asp.Prod != null)
            {
                shop.AddSellerProduct(asp.Prod);
                ListProducts();
            }
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog() { Title = "Select text file to import items from...", Filter = "Text Files | *.txt" };
            opg.ShowDialog();
            if (!string.IsNullOrEmpty(opg.FileName))
            {
                List<string> types = new List<string>();
                foreach (var s in shop.SellerProducts)
                    types.Add(s.Name);
                if (types.Count == 0 || types == null)
                {
                    Utils.ErrorMsg("Error", "Please make sure you've created at least one product type before proceeding.");
                    return;
                }
                AddStockFiles asf = new AddStockFiles(opg.FileName, types.ToArray());
                asf.ShowDialog(this);
                if (asf.Stock.Count > 0)
                {
                    foreach (var si in asf.Stock)
                        shop.AddStockItem(si);
                    ListStock();
                }
            }
        }

        private void singleItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> types = new List<string>();
            foreach (var s in shop.SellerProducts)
            {
                types.Add(s.Name);
            }
            if (types.Count == 0 || types == null)
            {
                Utils.ErrorMsg("Error", "Please make sure you've created at least one product type before proceeding.");
                return;
            }
            SingleItemStock sis = new SingleItemStock(types.ToArray());
            sis.ShowDialog(this);
            if (sis.Prod != null)
            {
                shop.AddStockItem(sis.Prod);
                ListStock();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchItems si = new SearchItems();
            si.Show(this);
        }

        private void exportStock_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog() { Title = "Export Stock To File...", Filter = "Text File | *.txt" };
            svg.ShowDialog();
            if (!string.IsNullOrEmpty(svg.FileName))
            {
                StringBuilder strb = new StringBuilder();
                foreach (var s in shop.Stock)
                {
                    strb.AppendLine(string.Format("{0}_{1}=>{2}", new object[] { s.ID.ToString("X"), s.ProductType, s.Value }));
                }
                string retval = strb.ToString();
                File.WriteAllText(svg.FileName, retval);
            }
        }

        private void dropDownComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dropDownComboBox1_SelectedIndexChanged(sender, e);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchHistory sch = new SearchHistory();
            sch.Show(this);
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListView3.SelectedObject != null)
            {
                HistoryProduct hp = (HistoryProduct)objectListView3.SelectedObject;
                DBUtils.RemoveHistoryItem(hp.ID);
                ListProducts();
                ListHistory();
            }
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryProduct[] hps = GetHistory(0);
            if (hps.Length > 0)
            {
                foreach (var h in hps)
                {
                    DBUtils.RemoveHistoryItem(h.ID);
                    shop.History.Remove(h);
                }
            }
            ListHistory();
        }

        private void lastWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryProduct[] hps = GetHistory(7);
            if (hps.Length > 0)
            {
                foreach (var h in hps)
                {
                    DBUtils.RemoveHistoryItem(h.ID);
                    shop.History.Remove(h);
                }
            }
            ListHistory();
        }

        private void lastMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryProduct[] hps = GetHistory(30);
            if (hps.Length > 0)
            {
                foreach (var h in hps)
                {
                    DBUtils.RemoveHistoryItem(h.ID);
                    shop.History.Remove(h);
                }
            }
            ListHistory();
        }

        private void everythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shop.History.Count > 0)
            {
                for (int i = 0; i < shop.History.Count; i++)
                {
                    DBUtils.RemoveHistoryItem(shop.History[i].ID);
                    shop.History.RemoveAt(i);
                }
                ListHistory();
            }
        }

        private void addNewItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (shop.SEProducts.Count > 0)
            {
                AddQueueItem aqi = new AddQueueItem();
                aqi.ShowDialog(this);
                if (aqi.Product != null)
                {
                    shop.AddQueueItem(aqi.Product);
                    ListQueue();
                }
            }
            else
                Utils.ErrorMsg("Error", "Please add at least one SE product from Items->Add New->SE/Refund Product.");
        }

        private void removeSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (objectListView4.SelectedObject != null)
            {
                ProductQueue prod = (ProductQueue)objectListView4.SelectedObject;
                DBUtils.RemoveQueueItem(prod.ID);
                shop.Queue.Remove(prod);
                ListQueue();
            }
        }

        private void objectListView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (objectListView4.SelectedObject != null)
                {
                    ProductQueue prod = (ProductQueue)objectListView4.SelectedObject;
                    DBUtils.RemoveQueueItem(prod.ID);
                    shop.Queue.Remove(prod);
                    ListQueue();
                }
            }

            if(e.KeyCode == Keys.Add)
            {
                if(objectListView4.SelectedObject != null)
                {
                    ProductQueue prod = (ProductQueue)objectListView4.SelectedObject;
                    CompleteQueue cq = new EasyPMS.CompleteQueue(prod);
                    cq.ShowDialog(this);
                    if(cq.hp != null)
                    {
                        shop.AddHistoryItem(cq.hp);
                        DBUtils.RemoveQueueItem(prod.ID);
                        shop.Queue.Remove(prod);
                        ListQueue();
                        ListHistory();
                    }
                }
            }
        }

        private void objectListView5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (objectListView5.SelectedObject != null)
                {
                    SEProduct prod = (SEProduct)objectListView5.SelectedObject;
                    DBUtils.RemoveSEProduct(prod.Name);
                    shop.SEProducts.Remove(prod);
                    ListSEProducts();
                }
            }
        }

        private void todayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductQueue[] pqs = GetProductQueue(0);
            if (pqs.Length > 0)
            {
                foreach (var p in pqs)
                {
                    DBUtils.RemoveQueueItem(p.ID);
                    shop.Queue.Remove(p);
                }
                ListQueue();
            }
        }

        private void lastWeekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductQueue[] pqs = GetProductQueue(7);
            if (pqs.Length > 0)
            {
                foreach (var p in pqs)
                {
                    DBUtils.RemoveQueueItem(p.ID);
                    shop.Queue.Remove(p);
                }
                ListQueue();
            }
        }

        private void lastMonthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductQueue[] pqs = GetProductQueue(30);
            if (pqs.Length > 0)
            {
                foreach (var p in pqs)
                {
                    DBUtils.RemoveQueueItem(p.ID);
                    shop.Queue.Remove(p);
                }
                ListQueue();
            }
        }

        private void everythingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (shop.Queue.Count > 0)
            {
                for (int i = 0; i < shop.Queue.Count; i++)
                {
                    DBUtils.RemoveQueueItem(shop.Queue[i].ID);
                    shop.Queue.RemoveAt(i);
                }
                ListQueue();
            }
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchQueue sq = new SearchQueue();
            sq.Show(this);
        }

        private void pPEliodecollioutlookcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("elio_decolli@outlook.com");
            MessageBox.Show("The email is ready to be pasted on PayPal. Thanks for donating :)");
        }
    }
}
