/*
    File name: Log.cs
    Author: Elio Decolli.
    Purpose:
        Writes events and shit.
    Last Updated: 9/26/2015
*/

using System;
using System.Text;
using System.IO;

    public class Log
    {
        private static FileStream Fstream;

        private static void LogEvent(string e, string level)
        {
            string final = string.Format("{0} -> [{1}]: {2}{3}", new object[] { DateTime.Now.ToString("dd/mm/yyy - hh:mm:ss"), level, e, Environment.NewLine });
            Console.Write(final);

            byte[] gbData = Encoding.ASCII.GetBytes(final);
            foreach (byte b in gbData)
                Fstream.WriteByte(b);
            Fstream.WriteByte((byte)'\n');
            Fstream.Flush();
        }

        public static void Initialize(string file, bool clear, bool logStart)
        {
            if (File.Exists(file) && clear)
                File.Delete(file);

            Fstream = File.Open(file, FileMode.OpenOrCreate);
            if (logStart)
                Debug("Log writting started.");
        }

        public static void Info(string txt)
        {
            LogEvent(txt, "I");
        }

        public static void Debug(string txt)
        {
            LogEvent(txt, "D");
        }

        public static void Error(string txt)
        {
            LogEvent(txt, "E");
        }

        public static void EndSession()
        {
            Debug("Ending log session.");
            Fstream.Close();
        }
    }
