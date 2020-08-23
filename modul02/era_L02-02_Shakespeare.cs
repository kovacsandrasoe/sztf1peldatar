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
            string nev;
            do
            {
                Console.Write("Add meg a nevet: ");
                nev = Console.ReadLine();
            }
            while (nev == "" || nev == "Shakespeare");
            Console.ReadLine();
        }
    }
}
