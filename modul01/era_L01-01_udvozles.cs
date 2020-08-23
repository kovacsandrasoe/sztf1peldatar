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
            Console.Write("Üdvözlöm, " + nev);
            Console.WriteLine("Üdvözlöm, {0}", nev);
            Console.WriteLine($"Üdvözlöm, {nev}");
            Console.ReadLine();
        }
    }
}
