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
            // Tömb feltöltése véletlen számokkal
            Random r = new Random();
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0, 101);
            }

            //Kilistázás
            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine();

            // 1. Tömb elemeinek összege - SOROZATSZÁMÍTÁS
            int szum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                szum += a[i];
            }
            Console.WriteLine("A tömb elemeinek összege: {0}", szum);

            // 2. Van-e 5-tel osztható szám a tömbben - ELDÖNTÉS
            bool vanEOttelOszthato;
            int j = 0;
            while ((j < a.Length) && (a[j] % 5 != 0))
            {
                j++;
            }
            vanEOttelOszthato = (j < a.Length);
            if (vanEOttelOszthato)
            {
                Console.WriteLine("Van öttel osztható szám");
            }
            else
            {
                Console.WriteLine("Nincs öttel osztható szám");
            }

            // 3. Ha tudjuk, hogy van öttel osztható szám, akkor mi az indexe. - KIVÁLASZTÁS

            int idx;
            if (vanEOttelOszthato)
            {
                idx = j;
                Console.WriteLine("Az öttel osztható szám indexe: {0}", idx);
            }

            //Van-e öttel osztható, és ha igen, akkor mi az indexe - LINEÁRIS KERESÉS
            bool vanE;
            int index;
            int l = 0;
            while ((l < a.Length) && (a[l] % 5 != 0))
            {
                l++;
            }
            vanE = (l < a.Length);
            if (vanE)
            {
                index = l;
                Console.WriteLine("Van öttel osztható szám, és az indexe: {0}", index);
            }
            else
            {
                Console.WriteLine("-1");
            }

            // Hány db 5-tel osztható szám van - MEGSZÁMLÁLÁS TÉTEL

            int db = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 5 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("Az öttel osztható számok darabszáma: {0}", db);

            // Tömb legkisebb értékének indexe - MINIMUMKIVÁLASZTÁS
            int min = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }
            }
            Console.WriteLine("A legkisebb elem indexe: {0}", min);
            Console.ReadLine();
        }
    }
}
