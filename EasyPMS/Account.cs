using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace EasyPMS
{
    public class Account
    {
        private string acc_name;
        private string hash_password_64;
        private List<Shop> shops;
        private string folderPath;

        public string AccountName { get { return acc_name; } }
        public string AccountPasswordHash { get { return hash_password_64; } }
        public Shop[] Shops { get { return shops.ToArray(); } }
        public string FolderPath { get { return folderPath; } }

        public Account(string name, string password, bool isPassHashed)
        {
            shops = new List<Shop>();
            acc_name = name;
            if (!isPassHashed)  // We are creating a new account here.
            {
                hash_password_64 = Utils.MD5Hash_64(password);
                DirectoryInfo di = Directory.CreateDirectory(AccountName); // Create a new folder for this shit.
                folderPath = di.FullName;
            }
            else
                hash_password_64 = password;
        }

        public void AddShop(Shop shop)
        {
            shops.Add(shop);
        }

        public byte[] ToArray()
        {
            MemoryStream memsr = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(memsr);
            writer.Write(acc_name);
            writer.Write(hash_password_64);
            writer.Write(folderPath);
            writer.Flush();
            return memsr.ToArray();
        }

        public void Save(string file)
        {
            byte[] data = ToArray();
            File.WriteAllBytes(file, data);
        }

        public static Account FromFile(string file)
        {
            Log.Debug("Reading account file " + file);
            byte[] data = File.ReadAllBytes(file);
            MemoryStream memsr = new MemoryStream(data);
            BinaryReader reader = new BinaryReader(memsr);

            string name = reader.ReadString();
            string pass = reader.ReadString();
            string path = reader.ReadString();
            Account acc = new Account(name, pass, true);
            acc.folderPath = path;
            Shop[] shops = DBUtils.LoadAllShops(path);
            DBUtils.EndConnection();
            acc.shops.AddRange(shops);
            Log.Debug("Account has been loaded!");
            return acc;
        }
    }
}
