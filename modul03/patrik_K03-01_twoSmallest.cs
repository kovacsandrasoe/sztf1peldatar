using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 19, 5, 42, 2, 77, 1, 22, 47, 32, 56, 98, 12, 14 };

            int x = numbers[0];
            int y = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < x)
                {
                    y = x;
                    x = numbers[i];
                }
                else if (numbers[i] < y)
                {
                    y = numbers[i];
                }
            }

            Console.WriteLine("A tömb két legkisebb elemének összege: " + (x + y));

            Console.ReadKey();
        }
    }
}
