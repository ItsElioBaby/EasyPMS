using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace EasyPMS
{
    public class LicenseValidator
    {

        public static string Version = "v1.0.0.1r";

        private static bool ValidateKey(string key)
        {
            // Convert the key to bytes
            byte[] bts = Convert.FromBase64String(key);

            // Check if the key is long enough
            if (bts.Length != 100)
            {
                Utils.ErrorMsg("Error", "Key-Validate: Key is not long 100 bytes, but " + bts.Length);
                return false;
            }

            // Check each position
            if (bts[0] != 0x00)
            {
                Utils.ErrorMsg("Error", "Key-Validate: Error #1");
                return false;
            }
            if (bts[49] != 0x01)
            {
                Utils.ErrorMsg("Error", "Key-Validate: Error #50");
                return false;
            }
            if (bts[99] != 0x00)
            {
                Utils.ErrorMsg("Error", "Key-Validate: Error #100");
                return false;
            }

            // The key seems to have a valid structure, now let's take a look further...
            byte[] firstData = new byte[50];
            byte[] secondData = new byte[50];

            Array.Copy(bts, 0, firstData, 0, 50);
            Array.Copy(bts, 49, secondData, 0, 50);

            // Check if we can get a date from that first thing
            try
            {
                long data = BitConverter.ToInt64(firstData, 1);
                DateTime.FromBinary(data);
            }
            catch (Exception) { Utils.ErrorMsg("Error", "Key-Validate: Error with data #1"); return false; }

            // Check if we can get a date from that second thing
            try
            {
                long data = BitConverter.ToInt64(secondData, 1);
                DateTime t = DateTime.FromBinary(data);

                if (DateTime.Now.CompareTo(t) > 0)
                {
                    Utils.ErrorMsg("Error", "Your license seems to have expired. Please contact me (eliodecolli@gmail.com) to renew it.");
                    return false;
                }
            }
            catch (Exception) { Utils.ErrorMsg("Error", "Key-Validate: Error with data #2"); return false; }

            // We're cool...
            Log.Debug("Key-Validate: Key seems to be fine.");
            return true;
        }

        public static bool Vailidate()
        {
            if (!File.Exists("license.pgl"))
            {
                Utils.ErrorMsg("Error", "License file has not been found! Please re-install the program or ask me for a new one.");
                return false;
            }
            string key = File.ReadAllText("license.pgl");
            return ValidateKey(key);
        }

        public static bool IsUpdateVailable()
        {
            using (WebClient wc = new WebClient())
            {
                string version = wc.DownloadString("https://dl.dropboxusercontent.com/u/15333708/epms_version.txt");
                if (version != Version)
                {
                    System.Windows.Forms.MessageBox.Show("There's a new update available. Please take a look where you've downloaded this tool to get the newest release.");
                    return true;
                }
            }
            return false;
        }
    }
}
