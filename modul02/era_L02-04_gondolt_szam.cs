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
            Random r = new Random();
            int gondoltSzam = r.Next(1, 11);
            int tippSzam;
            int szamlalo = 0;
            do
            {
                szamlalo++;
                Console.Write("Mire gondolsz? ");
                tippSzam = int.Parse(Console.ReadLine());
                if (tippSzam < gondoltSzam)
                {
                    Console.WriteLine("A gondolt szám nagyobb, mint a tipped.");
                }
                else if (tippSzam > gondoltSzam)
                {
                    Console.WriteLine("A gondolt szám kisebb, mint a tipped");
                }
                else // ha egyenlő
                {
                    Console.WriteLine("Gratulálok, eltaláltad. A gondolt szám {0} volt. {1} próbálkozásból eltaláltad.", gondoltSzam, szamlalo);
                }
            } while (tippSzam != gondoltSzam);
            Console.ReadLine();
        }
    }
}
