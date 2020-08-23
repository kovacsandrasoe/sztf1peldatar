using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a hőmérsékletet Celsius fokban: ");
            double hom_C = double.Parse(Console.ReadLine());
            double hom_F = hom_C * 9 / 5 + 32;

            Console.WriteLine("A hőmérséklet Fahrenheitben: " + hom_F);
            Console.ReadLine();
        }
    }
}
