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
            Console.Write("Add meg az 'a' oldalt: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Add meg a 'b' oldalt: ");
            int b = int.Parse(Console.ReadLine());

            int kerulet = 2 * (a + b);
            int terulet = a * b;

            Console.WriteLine("A téglalap kerülete: {0}, területe: {1}", kerulet, terulet);
            Console.ReadLine();
        }
    }
}
