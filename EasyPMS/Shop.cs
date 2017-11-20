using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyPMS
{
    public enum ShopType : int
    {
        Seller,
        SocialEngineer,
        Unknown
    }

    public class DailyReport
    {
        private int day;
        private int amountSold;
        private float unitPrice;

        public int Day { get { return day; } }
        public int AmountSold { get { return amountSold; } }
        public float UnitPrice { get { return unitPrice; } }

        public DailyReport(int day, int amount, float price)
        {
            this.day = day;
            amountSold = amount;
            unitPrice = price;
        }
    }

    public class SellerProduct
    {
        private string name;
        private float unitPrice;
        private float unitCost;
        private int stock;
        private int sold;

        public String Name { get { return name; } set { string oN = name; name = value; DBUtils.EditSellerProduct(oN, this); } }
        public float UnitPrice { get { return unitPrice; } set { unitPrice = value; TriggerUpdate(); } }
        public float UnitCost { get { return unitCost; } set { unitCost = value; TriggerUpdate(); } }
        public int Stock { get { return stock; } set { stock = value; TriggerUpdate(); } }
        public int Sold { get { return sold; } set { sold = value; TriggerUpdate(); } }
        public float UnitProfit { get { return UnitPrice - UnitCost; } }

        public SellerProduct(string name, float uPrice, float uCost, int stock, int sold)
        {
            this.name = name;
            unitPrice = uPrice;
            unitCost = uCost;
            this.stock = stock;
            this.sold = sold;
        }

        public void TriggerUpdate()
        {
            // Update using DBUtils
            DBUtils.EditSellerProduct(name, this);
        }
    }

    public class SEProduct
    {
        private string name;
        private int percentage;
        private float pPrice;
        //private float fPrice;
        private int ddPercentage;
        private bool isDD;

        public string Name { get { return name; } set { string oN = name; name = value; DBUtils.EditSEProduct(oN, this); } }
        public int Percentage { get { return percentage; } set { percentage = value; TriggerUpdate(); } }
        public int DoubleDipPercentage { get { return ddPercentage; } set { ddPercentage = value; TriggerUpdate(); } }
        //public float InitialProductPrice { get { return pPrice; } set { pPrice = value; } }
        //public bool IsDoubleDip { get { return isDD; } set { isDD = value; } }
        /*public float FinalPrice { get {
            if (!isDD)
            {
                return pPrice * (percentage / 100);
            }
            return pPrice * (ddPercentage / 100);
        } }*/

        public SEProduct(string name, int percentage, int doubleDipPercentage/*, bool isDoubleDip, float initialPrice*/)
        {
            this.name = name;
            this.percentage = percentage;
            this.ddPercentage = doubleDipPercentage;
            //this.isDD = isDoubleDip;
            //this.pPrice = initialPrice;
        }

        public void TriggerUpdate()
        {
            // Update using DBUtils
            DBUtils.EditSEProduct(name, this);
        }
    }

    public class HistoryProduct
    {
        private string name;
        private string buyerName;
        private float priceUnit;
        private string date;
        private int amount;
        private float totalPrice;
        private int id;
        private string summary;

        public string Name { get { return name; } }
        public string BuyerName { get { return buyerName; } set { buyerName = value; } }
        public float PriceUnit { get { return priceUnit; } set { priceUnit = value; } }
        public string Date { get { return date; } }
        public int Amount { get { return amount; } }
        public float TotalPrice { get { return totalPrice; } }
        public int ID { get { return id; } }
        public string Summary { get { return summary; } set { summary = value; } }

        public HistoryProduct(string name, string bname, float priceUnit, string date, int amount, string summary)
        {
            this.name = name;
            this.priceUnit = priceUnit;
            this.buyerName = bname;
            this.date = date;
            this.amount = amount;
            this.totalPrice = priceUnit*(float)amount;
            id = new Random().Next();
            this.summary = summary;
        }

        public HistoryProduct(string name, string bname, float priceUnit, string date, int amount, string summary, int id)
        {
            this.name = name;
            this.priceUnit = priceUnit;
            this.buyerName = bname;
            this.date = date;
            this.amount = amount;
            this.totalPrice = priceUnit * (float)amount;
            this.id = id;
            this.summary = summary;
        }
    }

    public class ProductQueue
    {
        private string productName, clientName, dateAdded;
        private int percentage;
        private float initialPrice;
        private float finalPrice;
        private int id;

        public ProductQueue(string pname, string cname, string dadded, int percnt, float initialPrice, float finalPrice)
        {
            productName = pname;
            clientName = cname;
            dateAdded = dadded;
            percentage = percnt;
            this.initialPrice = initialPrice;
            this.finalPrice = finalPrice;
            id = new Random().Next();
        }

        public ProductQueue(string pname, string cname, string dadded, int percnt, float initialPrice, float finalPrice, int id)
        {
            productName = pname;
            clientName = cname;
            dateAdded = dadded;
            percentage = percnt;
            this.initialPrice = initialPrice;
            this.finalPrice = finalPrice;
            this.id = id;
        }

        public string ProductName { get { return productName; } }
        public string ClientName { get { return clientName; } }
        public string DateAdded { get { return dateAdded; } }
        public int Percentage { get { return percentage; } }
        public float InitialPrice { get { return initialPrice; } }
        public float FinalPrice { get { return finalPrice; } }
        public int ID { get { return id; } }
    }

    public class StockProduct
    {
        private string details;
        private int id;
        private string prodType;
        public string Value { get { return details; } set { details = value; } }
        public int ID { get { return id; } }
        public string ProductType { get { return prodType; } }
        public static int StockProds = 0;

        public StockProduct(string info, string typ)
        {
            details = info;
            id = new Random(StockProds).Next();
            prodType = typ;
            StockProds++;
        }

        public StockProduct(string info, int _id, string typ)
        {
            details = info;
            id = _id;
            prodType = typ;
        }
    }

    public class Shop
    {
        private ShopType type;
        private string name;

        private List<SEProduct> se_products;
        private List<SellerProduct> products;

        private List<HistoryProduct> history;
        private List<ProductQueue> queue;

        private List<StockProduct> stock;

        public ShopType Type { get { return type; } }
        public string Name { get { return name; } }

        public List<SEProduct> SEProducts { get { return se_products; } }
        public List<SellerProduct> SellerProducts { get { return products; } }
        public List<HistoryProduct> History { get { return history; } }
        public List<ProductQueue> Queue { get { return queue; } }
        public List<StockProduct> Stock { get { return stock; } }

        public Shop(string name, ShopType type, SellerProduct[] sellerProducts,
            SEProduct[] seProducts, HistoryProduct[] history, ProductQueue[] queue, StockProduct[] stps)
        {
            this.type = type;
            this.name = name;
            this.se_products = new List<SEProduct>();
            this.products = new List<SellerProduct>();
            this.history = new List<HistoryProduct>();
            this.queue = new List<ProductQueue>();
            this.stock = new List<StockProduct>();
            if (seProducts != null) se_products.AddRange(seProducts);
            if(sellerProducts != null) products.AddRange(sellerProducts);
            if(history != null) this.history.AddRange(history);
            if(queue != null) this.queue.AddRange(queue);
            if (stps != null)
            {
                this.stock.AddRange(stps);
                StockProduct.StockProds = stps.Length;
            }
        }

        public bool ContainsSEProduct(string name)
        {
            var v = from i in se_products where i.Name == name select i;
            return v.Count() > 0;
        }

        public bool ContainsSellerProduct(string name)
        {
            var v = from i in products where i.Name == name select i;
            return v.Count() > 0;
        }

        public void AddSEProduct(SEProduct product)
        {
            if (!ContainsSEProduct(product.Name))
            {
                se_products.Add(product);
                DBUtils.AddSEProduct(product);
            }
        }

        public void AddSellerProduct(SellerProduct product)
        {
            if (!ContainsSellerProduct(product.Name))
            {
                products.Add(product);
                DBUtils.AddSellerProduct(product);
            }
        }

        public void AddHistoryItem(HistoryProduct product)
        {
            history.Add(product);
            DBUtils.AddHistoryItem(product);
        }

        public void AddQueueItem(ProductQueue product)
        {
            queue.Add(product);
            DBUtils.AddQueueItem(product);
        }

        public void AddStockItem(StockProduct product)
        {
            stock.Add(product);
            DBUtils.AddStockProduct(product);
            StockProduct.StockProds++;
        }

        public SellerProduct GetSellerProduct(string name)
        {
            foreach (var v in SellerProducts)
            {
                if (v.Name == name)
                    return v;
            }
            return null;
        }

        // Estimation is ONLY available if you're dealing with a Seller shop.
        public float GetTotalCost()
        {
            if (type == ShopType.Seller)
            {
                float cost = 0.0f;
                foreach (var s in products)
                    cost += (s.Stock * s.UnitCost);
                return cost;
            }
            throw new Exception("Invalid operation in a SE shop type.");
        }

        public float GetEstimatedRevenue()
        {
            if (type == ShopType.Seller)
            {
                float revenue = 0.0f;
                foreach (var s in products)
                    revenue += (s.Stock * s.UnitPrice);
                return revenue;
            }
            throw new Exception("Invalid operation in a SE shop type.");
        }

        public float GetEstimatedProfit()
        {
            if (type == ShopType.Seller)
            {
                float profit = GetEstimatedRevenue() - GetTotalCost();
                return profit;
            }
            throw new Exception("Invalid operation in a SE shop type.");
        }


        // The following works for both Seller and SE.
        public float GetCurrentRevenue()
        {
            float currentRevenue = 0.0f;
            foreach (var s in history)
                currentRevenue += (s.Amount * s.PriceUnit);
            return currentRevenue;
        }

        public float GetCurrentCost()
        {
            float currentCost = 0.0f;
            foreach (var s in history)
                currentCost += (s.Amount * s.PriceUnit);
            return currentCost;
        }

        public float GetCurrentProfit()
        {
            float cost = GetCurrentCost();
            float revenue = GetCurrentRevenue();
            return revenue - cost;
        }


        public DailyReport[] GetCurrentMonthProfits()
        {
            int cMonth = DateTime.Now.Month;
            var data = from i in history where Utils.GetMonthFromDateTime(i.Date) == cMonth select i;
            List<DailyReport> retvals = new List<DailyReport>();
            foreach (var s in data)
            {
                retvals.Add(new DailyReport(Utils.GetDayFromDateTime(s.Date), s.Amount, s.PriceUnit));
            }
            return retvals.ToArray();
        }
    }
}
