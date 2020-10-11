using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Focibajnoksag
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömb feltöltése, kiíratása
            int[,] foci = new int[6, 6];
            string[] csapatok = { "Angyalok", "Bikák", "Cicák", "Dongók", "Elvetemültek", "Focisták" };
            FociFeltoltes(foci);
            FociKiiratas(foci, csapatok);
            Console.WriteLine();

            int jatszott = FocicsapatJatszottE(csapatok);
            if (jatszott != -1)
            {
                Console.WriteLine("Van ilyen focicsapat a bajnokságon, az indexe " + jatszott);
            }
            else
            {
                Console.WriteLine("Nincs ilyen focicsapat a bajnokságon.");
            }
            Console.WriteLine();

            int szum = CsapatPontszam(foci, csapatok);
            Console.WriteLine("A csapat {0} pontot ért el a bajnokságon.", szum);
            Console.WriteLine();

            int[] pontszamok = CsapatonkentiPontszam(foci);
            Console.WriteLine("Csapatonkénti összpontszámok: ");
            for (int i = 0; i < pontszamok.Length; i++)
            {
                Console.WriteLine(csapatok[i] + ": " + pontszamok[i]);
            }
            Console.WriteLine();

            Console.WriteLine("A bajnokság nyertese: " + csapatok[BajnoksagNyertes(pontszamok)]);

            Console.ReadLine();

        }

        static void FociFeltoltes(int[,] tomb)
        {
            Random r = new Random();
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        tomb[i, j] = 0;
                    }
                    else
                    {
                        int rand = r.Next(0, 3);
                        if (rand == 0)
                        {
                            tomb[i, j] = 0;
                        }
                        else if (rand == 1)
                        {
                            tomb[i, j] = 1;
                        }
                        else
                        {
                            tomb[i, j] = 3;
                        }
                    }
                }
            }
        }

        static void FociKiiratas(int[,] tomb, string[] csapatok)
        {
            Console.WriteLine("A B C D E F".PadLeft(30));
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                Console.Write(csapatok[i].PadRight(19));
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write(tomb[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int FocicsapatJatszottE(string[] csapatok)
        {
            Console.Write("Add meg a csapat nevét: ");
            string csapat = Console.ReadLine();

            int i = 0;
            while (i < csapatok.Length && csapatok[i] != csapat)
            {
                i++;
            }

            if (i < csapatok.Length)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        static int CsapatPontszam(int[,] tomb, string[] csapatok)
        {
            int szum = 0;

            Console.Write("Melyik csapat összpontszámára vagy kíváncsi? ");
            string csapat = Console.ReadLine();

            //Csapat indexének megkeresése
            int i = 0;
            while (csapatok[i] != csapat)
            {
                i++;
            }
            int csapatindex = i;

            //Pont számítása
            //Sor
            for (int j = 0; j < tomb.GetLength(0); j++)
            {
                szum += tomb[csapatindex, j];
            }
            //Oszlop
            for (int k = 0; k < tomb.GetLength(1); k++)
            {
                szum += tomb[k, csapatindex];
            }

            return szum;
        }

        static int[] CsapatonkentiPontszam(int[,] tomb)
        {
            int[] pontszamok = new int[tomb.GetLength(0)];

            for (int i = 0; i < pontszamok.Length; i++)
            {
                int szum = 0;
                //Sor
                for (int j = 0; j < tomb.GetLength(0); j++)
                {
                    szum += tomb[i, j];
                }
                //Oszlop
                for (int k = 0; k < tomb.GetLength(1); k++)
                {
                    szum += tomb[k, i];
                }
                pontszamok[i] = szum;
            }

            return pontszamok;
        }

        static int BajnoksagNyertes(int[] pontszamok)
        {
            int max = 0;

            for (int i = 1; i < pontszamok.Length; i++)
            {
                if (pontszamok[i] > pontszamok[max])
                {
                    max = i;
                }
            }

            return max;
        }

    }
}
