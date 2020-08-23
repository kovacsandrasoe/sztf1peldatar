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
            string[] honapok = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
            bool honapE;
            do
            {
                Console.Write("Add meg a hónapot: ");
                string honap = Console.ReadLine();
                int i = 0;
                while (i < honapok.Length && honapok[i] != honap)
                {
                    i++;
                }
                honapE = i < honapok.Length;
            } while (!honapE);
            Console.ReadLine();
        }
    }
}
