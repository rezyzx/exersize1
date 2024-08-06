using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lingkaran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("silahkan masukan angka pertama");
            double jari = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double phi = 3.14;

            double luas = jari * jari * phi;
            double keliling = (jari + jari) * phi;
            Console.WriteLine($"Luas : {luas}\nKeliling : {keliling}");
        }
    }
}
