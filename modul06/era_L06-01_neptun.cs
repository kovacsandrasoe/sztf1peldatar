using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekAStringekkel_L3
{
    class Program
    {
        static void Main(string[] args)
        {
            // neptun kód generálás
            Random r = new Random();

            string neptunKod = "";

            for (int i = 0; i < 6; i++)
            {
                if (r.Next(2) == 0) // 0 vagy 1
                {
                    neptunKod += r.Next(0, 10);
                }
                else
                {
                    neptunKod += (char)r.Next('A', ((int)'Z') + 1); // a +1 amiatt kell, hogy a Z karaktere is benne legyen a kimenetben
                }
            }

            Console.WriteLine("Az előállított neptunkód: {0}", neptunKod);
            Console.ReadLine();
        }
    }
}
