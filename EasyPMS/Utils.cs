using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EasyPMS
{
    public class Utils
    {
        public static DialogResult InfoMsg(string title, string text)
        {
            return MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult InfoMsg2(string title, string text)
        {
            return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static void ErrorMsg(string title, string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string MD5Hash_64(string str)
        {
            byte[] pData = Encoding.ASCII.GetBytes(str);

            byte[] pHashed;
            using (MD5 md5 = MD5.Create())
            {
                pHashed = md5.ComputeHash(pData);
            }

            return Convert.ToBase64String(pHashed);
        }

        public static int GetMonthFromDateTime(string dt)
        {
            // Format: dd/mm/yyy
            return DateTime.Parse(dt).Month;
        }

        public static int GetDayFromDateTime(string dt)
        {
            // Format: dd/mm/yyy
            return DateTime.Parse(dt).Day;
        }
    }
}
