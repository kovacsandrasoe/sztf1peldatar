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
            Console.Write("Add meg a nevet: ");
            string nev = Console.ReadLine();
            if (nev == "Béla")
            {
                Console.WriteLine("Szia");
            }
            else
            {
                Console.WriteLine("Hello");
            }
            Console.ReadLine();
        }
    }
}
