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
            Console.Write("Mi a neved? ");
            string nev3 = Console.ReadLine();
            if (nev3 == "Béla")
            {
                Console.WriteLine("SZIA");
            }
            else if (nev3 == "Bill")
            {
                Console.WriteLine("A király!");
            }
            else if (nev3 == "Joe")
            {
                Console.WriteLine("Szevasz!");
            }
            Console.ReadLine();
        }
    }
}
