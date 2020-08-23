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
            Console.Write("Hány elemet olvasol be? ");
            int n = int.Parse(Console.ReadLine());
            int[] tomb = new int[n];
            double pozitivok = 0; //pozitívok összege
            int pozitivDB = 0; //pozitívok darabszáma
            int negativok = 0; //negatívok összege
            int zerusokDB = 0; //zérusok darabszáma

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. elem:", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
                if (tomb[i] > 0) //Ha az adott elem nagyobb, mint 0.
                {
                    pozitivDB++;
                    pozitivok += tomb[i];
                }
                else if (tomb[i] < 0) // Ha kisebb, mint 0.
                {
                    negativok += tomb[i];
                }
                else // Ha 0
                {
                    zerusokDB++;
                }
            }

            double pozitivAtlag = pozitivok / pozitivDB;
            Console.WriteLine("Pozitívok átlaga: {0}", pozitivAtlag);
            Console.WriteLine("Negatívok összege: {0}", negativok);
            Console.WriteLine("Zérusok darabszáma: {0}", zerusokDB);
            Console.ReadLine();
        }
    }
}
