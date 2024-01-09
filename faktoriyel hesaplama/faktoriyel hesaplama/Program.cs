using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayi Giriniz : ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            double faktoriyel = 1;

            for (int i = 1; i <=sayi; i++)
            {
                faktoriyel = faktoriyel *= i;
            }
            Console.WriteLine(sayi + "! = " + faktoriyel);
            Console.ReadKey();
        }
    }
}
