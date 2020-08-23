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
            double val;
            double exponent;
            double hatvanyeredmeny;
            Console.Write("Add meg a számot, aminek a hatványát szeretnéd kiszámolni: ");
            val = int.Parse(Console.ReadLine());
            Console.Write("Add meg a kitevőt: ");
            exponent = int.Parse(Console.ReadLine());
            hatvanyeredmeny = Math.Pow(val, exponent);
            Console.WriteLine("A " + val + " " + exponent + ". hatványa: " + hatvanyeredmeny);

            int szam;
            int faktorialis = 1;
            Console.Write("Melyik számnak szeretnéd megtudni a faktoriálisát? ");
            szam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                faktorialis = faktorialis * i;
            }
            Console.WriteLine("A(z) " + szam + " faktoriálisa: " + faktorialis);
            Console.ReadLine();
        }
    }
}
