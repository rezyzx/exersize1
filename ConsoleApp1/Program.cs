using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("silahkan masukan detik");
            double angka1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

         double hasil = angka1 / 60;
         double hasil2 = angka1 / 3600;

            Console.WriteLine(hasil);
            Console.WriteLine(hasil2);
        }
    }
}
