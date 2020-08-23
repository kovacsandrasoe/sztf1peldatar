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
            double sz1;
            double sz2;
            char muv;
            double eredmeny;
            Console.Write("Első szám: ");
            sz1 = double.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            sz2 = double.Parse(Console.ReadLine());
            Console.Write("Művelet: (+, -, *, /): ");
            muv = char.Parse(Console.ReadLine());
            switch (muv)
            {
                case '+':
                    eredmeny = sz1 + sz2;
                    Console.WriteLine("Az eredmény: " + eredmeny.ToString());
                    break;
                case '-':
                    eredmeny = sz1 - sz2;
                    Console.WriteLine("Az eredmény: " + eredmeny.ToString());
                    break;
                case '*':
                    eredmeny = sz1 * sz2;
                    Console.WriteLine("Az eredmény: " + eredmeny.ToString());
                    break;
                case '/':
                    eredmeny = sz1 / sz2;
                    Console.WriteLine("Az eredmény: " + eredmeny.ToString());
                    break;
                default:
                    Console.WriteLine("Rossz műveletet adtál meg.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
