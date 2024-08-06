using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka1, hasil;
            Console.WriteLine("silahkan masukan nama");
            string nama = Console.ReadLine();
            Console.WriteLine("silahkan masukan tahun lahir");
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine();


            hasil = 2024 - angka1;

            Console.WriteLine("umur :" + hasil);
            Console.WriteLine("nama :" + nama);
        }
    }
}
