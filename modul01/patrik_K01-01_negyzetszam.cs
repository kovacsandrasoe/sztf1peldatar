using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adjon meg egy egész számot: ");
            int number = int.Parse(Console.ReadLine());

            #region 1. Megoldás

            int squareRoot = (int)Math.Sqrt(number);
            Console.WriteLine("Négyzet szám? -> "+ (squareRoot*squareRoot==number));

            #endregion
            #region 2. Megoldás

            Console.WriteLine("Négyzet szám? -> " + (Math.Sqrt(number) % 1 == 0));

            #endregion
            #region 3. Megoldás

            Console.WriteLine("Négyzet szám? -> " + (Math.Sqrt(number) == (int)Math.Sqrt(number)));

            #endregion

            Console.ReadKey();
        }
    }
}
