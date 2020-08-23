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
            int[] nemNegativTomb = new int[pozitivDB + zerusokDB];
            int nemNegativDB = -1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] >= 0)
                {
                    nemNegativDB++;
                    nemNegativTomb[nemNegativDB] = tomb[i];
                }
            }
            for (int i = 0; i < nemNegativTomb.Length; i++)
            {
                Console.WriteLine(nemNegativTomb[i]);
            }
            Console.ReadLine();
        }
    }
}
