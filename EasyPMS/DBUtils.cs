using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;
using System.Data;

namespace EasyPMS
{
    public class DBUtils
    {
        public static string CopyDataSample(string shopName, string folderName)
        {
            Log.Info(string.Format("Copying sample file to {0}...", folderName));
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);
            string namePath = Path.Combine(Environment.CurrentDirectory, folderName + "\\" + shopName + "_shop.sdf");
            File.Copy("shop_template.sdf",  namePath);
            return namePath;
        }

        public static SqlCeConnection CurrentConnection = null;
        public static string DbSource;

        public static void StartConnection(string dbName)
        {
            CurrentConnection = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", dbName));
            CurrentConnection.Open();
            DbSource = dbName;
            Log.Info(string.Format("Connected to data source {0}", dbName));
        }

        public static void EndConnection()
        {
            if (CurrentConnection != null)
            {
                if (CurrentConnection.State == ConnectionState.Open)
                    CurrentConnection.Close();
                Log.Info(string.Format("Closed connection to {0}", CurrentConnection.DataSource));
            }
        }

        public static void CreateNewShop(Shop shp, string accName)
        {
            string source = CopyDataSample(shp.Name, accName); // Prepare the database.

            StartConnection(source); // Start your connection.

            // Load the existing data.
            foreach (var v in shp.History)
                AddHistoryItem(v);
            foreach (var v in shp.Queue)
                AddQueueItem(v);
            foreach (var v in shp.SellerProducts)
                AddSellerProduct(v);
            foreach (var v in shp.SEProducts)
                AddSEProduct(v);

            // Update Shop details.
            using (SqlCeCommand cmd = new SqlCeCommand("INSERT INTO ShopData (ShopName, ShopType) VALUES (@NAME, @TYPE)", CurrentConnection))
            {
                cmd.Parameters.Add("@NAME", shp.Name);
                cmd.Parameters.Add("@TYPE", (int)shp.Type);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                {
                    Utils.ErrorMsg("Error", "Cannot create shop.");
                    return;
                }
            }
            Log.Info("Created new shop " + shp.Name);
        }

        public static Shop[] LoadAllShops(string path)
        {
            List<Shop> retvals = new List<Shop>();
            foreach (var f in Directory.GetFiles(path))
            {
                if (Path.GetExtension(f) == ".sdf")
                {
                    StartConnection(f);
                    retvals.Add(LoadShop());
                    EndConnection();
                }
            }
            return retvals.ToArray();
        }

        #region LoadData
        public static SEProduct[] LoadSEProducts()
        {
            List<SEProduct> products = new List<SEProduct>();
            StartConnection(DbSource);
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM ShopSEProducts", CurrentConnection))
            {
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        int percentage = reader.GetInt32(1);
                        int ddpercentage = reader.GetInt32(2);
                        SEProduct p = new SEProduct(name, percentage, ddpercentage);
                        products.Add(p);
                        Log.Info("Loading SE product " + name);
                    }
                }
            }
            EndConnection();
            return products.ToArray();
        }

        public static SellerProduct[] LoadSellerProducts()
        {
            List<SellerProduct> products = new List<SellerProduct>();
            StartConnection(DbSource);
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM ShopProducts", CurrentConnection))
            {
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        float unitCost = (float)reader.GetDouble(1);
                        float unitPrice = (float)reader.GetDouble(2);
                        int stock = reader.GetInt32(3);
                        int sold = reader.GetInt32(4);
                        SellerProduct p = new SellerProduct(name, unitPrice, unitCost, stock, sold);
                        products.Add(p);
                        Log.Info("Loading seller product " + name);
                    }
                }
            }
            EndConnection();
            return products.ToArray();
        }

        public static HistoryProduct[] LoadHistory()
        {
            List<HistoryProduct> products = new List<HistoryProduct>();
            StartConnection(DbSource);
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM ShopHistory", CurrentConnection))
            {
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string buyerName = reader.GetString(0);
                        string productName = reader.GetString(1);
                        int amount = reader.GetInt32(2);
                        float priceUnit = (float)reader.GetDouble(3);
                        float totalPrice = (float)reader.GetDouble(4);
                        string date = reader.GetString(5);
                        int id = reader.GetInt32(6);
                        string sum = reader.GetString(7);
                        HistoryProduct p = new HistoryProduct(productName, buyerName, priceUnit, date, amount, sum, id);
                        products.Add(p);
                    }
                }
            }
            EndConnection();
            Log.Info("History has been loaded.");
            return products.ToArray();
        }

        public static ProductQueue[] LoadQueue()
        {
            List<ProductQueue> products = new List<ProductQueue>();
            StartConnection(DbSource);
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Queue", CurrentConnection))
            {
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string clientName = reader.GetString(0);
                        string dateAdded = reader.GetString(1);
                        int percentage = reader.GetInt32(2);
                        float initialPrice = (float)reader.GetDouble(3);
                        float finalPrice = (float)reader.GetDouble(4);
                        string productName = reader.GetString(5);
                        int id = reader.GetInt32(6);
                        ProductQueue p = new ProductQueue(productName, clientName, dateAdded, percentage, initialPrice, finalPrice, id);
                        products.Add(p);
                    }
                }
            }
            EndConnection();
            Log.Info("Queue has been loaded.");
            return products.ToArray();
        }

        public static StockProduct[] LoadStock()
        {
            List<StockProduct> retvals = new List<StockProduct>();
            StartConnection(DbSource);
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Stock", CurrentConnection))
            {
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string details = reader.GetString(2);
                        int id = reader.GetInt32(0);
                        string typ = reader.GetString(1);
                        retvals.Add(new StockProduct(details, id, typ));
                    }
                }
            }
            EndConnection();
            return retvals.ToArray();
        }

        public static Shop LoadShop()
        {
            // Firstly load the shop main data to see what kind of shop we're dealing with...
            ShopType type = ShopType.Unknown;
            string shopName = null;
            StartConnection(DbSource);
            using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM ShopData", CurrentConnection))
            {
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        shopName = reader.GetString(0);
                        Log.Info("Loaded name: " + shopName);
                        type = (ShopType)reader.GetInt32(1);
                        Log.Info("Loaded type: " + Enum.GetName(typeof(ShopType), type));
                    }
                }
            }

            if (type == ShopType.Seller)
            {
                // Don't load SE thingies..
                HistoryProduct[] hps = LoadHistory();
                SellerProduct[] sp = LoadSellerProducts();
                StockProduct[] stp = LoadStock();
                CurrentConnection.Close();
                CurrentConnection = null;
                Log.Info("Loaded seller shop " + shopName);
                EndConnection();
                return new Shop(shopName, type, sp, null, hps, null, stp);
            }
            else if (type == ShopType.SocialEngineer)
            {
                // Don't load seller thingies...
                ProductQueue[] queue = LoadQueue();
                SEProduct[] sep = LoadSEProducts();
                CurrentConnection.Close();
                CurrentConnection = null;
                Log.Info("Loaded SE/Refunds shop " + shopName);
                EndConnection();
                return new Shop(shopName, type, null, sep, null, queue, null);
            }
            else if (type == ShopType.Unknown)
            {
                Utils.ErrorMsg("Error", "Error while loading one of the shops. Type: unkown.");
            }
            EndConnection();
            return null;
        }
        #endregion

        #region ShopProcducts Add/Remove
        public static void AddSEProduct(SEProduct product)
        {
            StartConnection(DbSource);
            using (SqlCeCommand cmd = new SqlCeCommand("INSERT INTO ShopSEProducts (Name,Percentage,DoubleDipPercentage) VALUES(@NAME,@PERCT,@DDPERCT)", CurrentConnection))
            {
                cmd.Parameters.Add("@NAME", product.Name);
                cmd.Parameters.Add("@PERCT", product.Percentage);
                cmd.Parameters.Add("@DDPERCT", product.DoubleDipPercentage);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't insert a new SE prodcut into our records.");
            }
        }

        public static void AddSellerProduct(SellerProduct product)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
                conn.Open();
                SqlCeCommand cmd = new SqlCeCommand("INSERT INTO ShopProducts (ProductName,ProductUnitCost,ProductUnitPrice,Stock,Sold) VALUES (@NAME, @UC,@UP,@STOCK,@SOLD)", conn);
                
                    cmd.Parameters.AddWithValue("@NAME", product.Name);
                    cmd.Parameters.AddWithValue("@UC", (decimal)product.UnitCost);
                    cmd.Parameters.AddWithValue("@UP", (decimal)product.UnitPrice);
                    cmd.Parameters.AddWithValue("@STOCK", product.Stock);
                    cmd.Parameters.AddWithValue("@SOLD", product.Sold);

                    int res = cmd.ExecuteNonQuery();
                    if (res == 0)
                        Utils.ErrorMsg("Error", "We couldn't add a new seller product to our records.");
                conn.Close();
        }

        public static void EditSEProduct(string name, SEProduct nData)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            SqlCeCommand cmd = new SqlCeCommand("UPDATE ShopSEProducts SET Name=@NN,Percentage=@PERCT,DoubleDipPercentage=@DDP WHERE Name=@NAME", conn);
                cmd.Parameters.Add("@NAME", name);
                cmd.Parameters.Add("@NN", nData.Name);
                cmd.Parameters.Add("@PERCT", nData.Percentage);
                cmd.Parameters.Add("@DDP", nData.DoubleDipPercentage);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't update our records.");
                conn.Close();
        }

        public static void RemoveSEProduct(string name)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("DELETE FROM ShopSEProducts WHERE Name=@NAME", conn))
            {
                cmd.Parameters.Add("@NAME", name);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }

        public static void RemoveSellerProduct(string name)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("DELETE FROM ShopProducts WHERE ProductName=@NAME", conn))
            {
                cmd.Parameters.Add("@NAME", name);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }

        public static void EditSellerProduct(string name, SellerProduct nData)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand(@"UPDATE ShopProducts SET ProductName=@NN, ProductUnitCost=@UC, ProductUnitPrice=@UP, Stock=@STOCK, Sold=@SOLD
                                                        WHERE ProductName=@NAME", conn))
            {
                cmd.Parameters.Add("@NAME", name);
                cmd.Parameters.Add("@NN", nData.Name);
                cmd.Parameters.Add("@UC", (decimal)nData.UnitCost);
                cmd.Parameters.Add("@UP", (decimal)nData.UnitPrice);
                cmd.Parameters.Add("@STOCK", nData.Stock);
                cmd.Parameters.Add("@SOLD", nData.Sold);

                int res = cmd.ExecuteNonQuery();
                /*if (res == 0)
                {
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
                    return;
                }*/
                if (name != nData.Name)
                {
                    RenameHistoryProductsType(name, nData.Name);
                    RenameStockProductsType(name, nData.Name);
                }
                Log.Info(string.Format("Updated seller product {0}", name));
            }
            conn.Close();
        }

        public static void AddStockProduct(StockProduct prod)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            SqlCeCommand cmd = new SqlCeCommand("INSERT INTO Stock (ID,ProductName,Details) VALUES(@ID,@TYP,@DET)", conn);
                cmd.Parameters.Add("@DET", prod.Value);
                cmd.Parameters.Add("@ID", prod.ID);
                cmd.Parameters.Add("@TYP", prod.ProductType);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't insert a new stock into our records.");
            conn.Close();
        }

        public static void EditStockProduct(int id, string details)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("UPDATE Stock SET Details=@DET WHERE ID=@ID", conn))
            {
                cmd.Parameters.Add("@DET", details);
                cmd.Parameters.Add("@ID", id);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't edit stock item with ID " + id.ToString("X") + ".");
            }
            conn.Close();
        }

        public static void RemoveStockProduct(int id)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("DELETE FROM Stock WHERE ID=@ID", conn))
            {
                cmd.Parameters.Add("@ID", id);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }

        public static void RenameStockProductsType(string oldType, string nType)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("UPDATE Stock SET ProductName=@PN WHERE ProductName=@OPN", conn))
            {
                cmd.Parameters.Add("@PN", nType);
                cmd.Parameters.Add("@OPN", oldType);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }

        public static void RenameHistoryProductsType(string oldType, string nType)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("UPDATE ShopHistory SET ProductBought=@PN WHERE ProductBought=@OPN", conn))
            {
                cmd.Parameters.Add("@PN", nType);
                cmd.Parameters.Add("@OPN", oldType);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }
#endregion

        #region Shop History/Queue

        public static void AddHistoryItem(HistoryProduct product)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand(@"INSERT INTO ShopHistory (BuyerName, ProductBought, AmountBought, PriceUnit, TotalPrice, Date, HistoryID, Summary) 
                                                       VALUES (@BN, @PB, @AB, @PU, @TP, @DT, @ID, @SUM)", conn))
            {
                cmd.Parameters.Add("@BN", product.BuyerName);
                cmd.Parameters.Add("@PB", product.Name);
                cmd.Parameters.Add("@AB", product.Amount);
                cmd.Parameters.Add("@PU", (decimal)product.PriceUnit);
                cmd.Parameters.Add("@TP", (decimal)(product.PriceUnit * (float)product.Amount));
                cmd.Parameters.Add("@DT", product.Date);
                cmd.Parameters.Add("@ID", product.ID);
                cmd.Parameters.Add("@SUM", product.Summary);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }

        public static void RemoveHistoryItem(int id)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("DELETE FROM ShopHistory WHERE HistoryID=@ID", conn))
            {
                cmd.Parameters.Add("@ID", id);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't complete your request.");
            }
            conn.Close();
        }

        public static void AddQueueItem(ProductQueue product)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand(@"INSERT INTO Queue (ClientName, AddedDate, Percentage, InitialPrice, FinalPrice, ProductName, QueueID)
                                                        VALUES (@CN, @AD, @P, @IP, @FP, @PN, @QID)", conn))
            {
                cmd.Parameters.Add("@CN", product.ClientName);
                cmd.Parameters.Add("@AD", product.DateAdded);
                cmd.Parameters.Add("@P", product.Percentage);
                cmd.Parameters.Add("@IP", (decimal)product.InitialPrice);
                cmd.Parameters.Add("@FP", (decimal)product.FinalPrice);
                cmd.Parameters.Add("@PN", product.ProductName);
                cmd.Parameters.Add("@QID", product.ID);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }

        public static void RemoveQueueItem(int id)
        {
            SqlCeConnection conn = new SqlCeConnection(string.Format("Data Source={0};Persist Security Info=False;", DbSource));
            conn.Open();
            using (SqlCeCommand cmd = new SqlCeCommand("DELETE FROM Queue WHERE QueueID=@ID", conn))
            {
                cmd.Parameters.Add("@ID", id);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    Utils.ErrorMsg("Error", "We couldn't process your request.");
            }
            conn.Close();
        }

        #endregion
    }
}
