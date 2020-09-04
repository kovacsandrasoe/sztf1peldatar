using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendezesek_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[10];

            TombotEloallit(t);

            TombotMegjelenit(t);

            MinimumKivalasztasosRendezes(t);
            Console.WriteLine();

            TombotMegjelenit(t);

            Console.ReadLine();
        }

        static void MinimumKivalasztasosRendezes(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[min] > tomb[j])
                    {
                        min = j;
                    }
                }

                Csere(ref tomb[i], ref tomb[min]);
            }
        }

        private static void Csere(ref int egyik, ref int masik)
        {
            int seged = egyik;
            egyik = masik;
            masik = seged;
        }

        private static void TombotMegjelenit(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("{0} ", t[i]);
            }
        }

        static void TombotEloallit(int[] tomb)
        {
            Random r = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 21);
            }
        }
    }
}
