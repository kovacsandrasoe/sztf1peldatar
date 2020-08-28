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
            int szam;
            int kitevo;
            double hatvanyeredmeny;
            Console.Write("Melyik számnak szeretnéd kiszámolni a hatványát és a faktoriálisát? ");
            szam = int.Parse(Console.ReadLine());
            Console.Write("Add meg a hatványkitevőt: ");
            kitevo = int.Parse(Console.ReadLine());
            hatvanyeredmeny = Math.Pow(szam, kitevo);

            Console.WriteLine("A(z) " + szam + " "+ kitevo + ". hatványa: " + hatvanyeredmeny);

            double faktorialis = 1;
            for (int i = 1; i <= szam; i++)
            {
                faktorialis = faktorialis * i;
            }

            Console.WriteLine("A(z) " + szam + " faktoriálisa: " + faktorialis);
            Console.ReadLine();
        }
    }
}
