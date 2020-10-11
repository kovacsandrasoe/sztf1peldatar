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
            //Rendezések
            // Töltsünk fel egy string tömböt a felhasználó által megadott elemszámmal. 
            // Javított beillesztéses rendezéssel tegyük ábécérendbe az elemeket.
            string[] szovegek = TombBeker();
            JavitottBeillesztesesRendezes(szovegek);
            Console.WriteLine(StringTombMegjelenit(szovegek));

            Console.ReadLine();
        }

        static string[] TombBeker()
        {
            Console.Write("Tömb elemszáma: ");
            int elemszam = int.Parse(Console.ReadLine());
            string[] tomb = new string[elemszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("Aktuális szöveg: ");
                tomb[i] = Console.ReadLine();
            }

            return tomb;
        }

        static bool StringKisebbE(string elso, string masodik)
        {
            int i = 0;
            while (i < elso.Length && i < masodik.Length && elso[i] == masodik[i])
            {
                i++;
            }
            if (i >= elso.Length)  // alma    almafa
            {
                return true;
            }
            if (i >= masodik.Length)  // almafa    alma
            {
                return false;
            }
            if (elso[i] < masodik[i]) // barack   körte
            {
                return true; // barack
            }
            else
            {
                return false;
            }

        }

        static void JavitottBeillesztesesRendezes(string[] tomb)
        {
            for (int i = 1; i < tomb.Length; i++)
            {
                int j = i - 1;
                string seged = tomb[i];
                while (j >= 0 && StringKisebbE(seged, tomb[j]))
                {
                    tomb[j + 1] = tomb[j];
                    j = j - 1;
                }
                tomb[j + 1] = seged;
            }
        }

        static string StringTombMegjelenit(string[] tomb)
        {
            string s = "";
            for (int i = 0; i < tomb.Length; i++)
            {
                s += tomb[i] + "\n";
            }
            return s;
        }

    }
}
