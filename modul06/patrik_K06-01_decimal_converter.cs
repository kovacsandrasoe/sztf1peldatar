using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Decimal to Binary Converter - Normal
            Console.Write("Kérem adja meg az átváltani kívánt számot: ");
            int dec = int.Parse(Console.ReadLine());

            string bin = "";
            while (dec != 0)
            {
                if (dec % 2 == 0)
                    bin += "0";
                else
                    bin += "1";

                dec = dec / 2;
            }

            bin = Reverse(bin);
            Console.WriteLine("A kért szám bináris alakja: " + bin);
            #endregion
            #region Decimal to Binary Converter - Cheat
            //Átkonvertálja automatikusan bináris formátumba a megadott számot :))
            //bin = Convert.ToString(dec, 2);
            #endregion

            Console.ReadKey();
        }

        //Helyes sorrendbe rendezzük a feljegyzett számokat.
        public static string Reverse(string s)
        {
            string temp = "";

            for (int i = s.Length; i > 0; i--)
            {
                temp += s[i - 1];
            }

            return temp;
        }
    }
}
