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
            Console.Write("Add meg az életkort: ");
            int eletkor = int.Parse(Console.ReadLine());
            Console.WriteLine("Üdvözlöm, {0} éves {1}", eletkor, nev);
            Console.ReadLine();
        }
    }
}
