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
            int non_decimal = int.Parse(Console.ReadLine());

            string dec = "";
            while (non_decimal != 0)
            {
                if (non_decimal % 2 == 0)
                    dec += "0";
                else
                    dec += "1";

                non_decimal = non_decimal / 2;
            }

            dec = Reverse(dec);
            Console.WriteLine("A kért szám decimális alakja: " + dec);
            #endregion
            #region Decimal to Binary Converter - Cheat
            //Átkonvertálja automatikusan bináris formátumba a megadott számot :))
            //dec = Convert.ToString(non_decimal, 2);
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
