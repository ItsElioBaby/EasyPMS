using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Licenser
{
    class Program
    {
        static byte[] GenerateKey(DateTime exp)
        {
            MemoryStream memsr = new MemoryStream(100);
            using (BinaryWriter writer = new BinaryWriter(memsr))
            {
                writer.Write((byte)0x00); //1st header
                byte[] bts1 = new byte[40];
                new Random().NextBytes(bts1);
                writer.Write(DateTime.Now.ToBinary());
                writer.Write(bts1);
                writer.Write((byte)0x01); //2nd header
                bts1 = new byte[41];
                writer.Write(exp.ToBinary());
                new Random().NextBytes(bts1);
                writer.Write(bts1);
                writer.Write((byte)0x00); //3rd header
                writer.Flush();
            }
            return memsr.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Title = "PGL Licenser";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Please enter what you wish to add (d/m/y):");
            string dt = Console.ReadLine();
            if (dt == "d")
            {
                Console.WriteLine("Enter the amout of days:");
                int days = int.Parse(Console.ReadLine());
                DateTime t = DateTime.Now.AddDays(days);
                byte[] key = GenerateKey(t);
                File.WriteAllText("license.pgl", Convert.ToBase64String(key));
                Console.WriteLine("License has been created!");
                Console.Read();
            }
            if(dt == "m")
            {
                Console.WriteLine("Enter the amout of months:");
                int days = int.Parse(Console.ReadLine());
                DateTime t = DateTime.Now.AddMonths(days);
                byte[] key = GenerateKey(t);
                File.WriteAllText("license.pgl", Convert.ToBase64String(key));
                Console.WriteLine("License has been created!");
                Console.Read();
            }
            if (dt == "y")
            {
                Console.WriteLine("Enter the amout of years:");
                int days = int.Parse(Console.ReadLine());
                DateTime t = DateTime.Now.AddYears(days);
                byte[] key = GenerateKey(t);
                File.WriteAllText("license.pgl", Convert.ToBase64String(key));
                Console.WriteLine("License has been created!");
                Console.Read();
            }
            if (dt != "d" && dt != "m" && dt != "y")
            {
                Console.WriteLine("Error!");
                Console.Read();
            }
        }
    }
}
