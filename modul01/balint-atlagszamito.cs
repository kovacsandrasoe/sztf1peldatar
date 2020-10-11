using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlagSzamito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a Szoftvertervezés és fejlesztés I. jegyet!");
            int sztf1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem az Analízis I. jegyet!");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a Dimat I. jegyet!");
            int dimat = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a Bevezetés az informatikába jegyet!");
            int bevinfo = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a Villamosságtan jegyet!");
            int villtan = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a Markoökonómia jegyet!");
            int makro = int.Parse(Console.ReadLine());

            //Ösztöndíj átlagot mindig 30-al osztjuk
            //Double-ként definiáljuk, különben egész számként lesz elosztva és elvész a tizedes rész
            double osztondijOszto = 30;

            //Ahhoz hogy double legyen a kimenete az osztásnak az egyik oldalnak legalább double-nek kell lennie.
            //Ezt vagy a 3 sorral feljebb lévő előre definiálással, vagy kasztolással csináljuk meg
            //Itt használjuk az előre definiált változót, így double lesz a kimenet
            double atlag = (sztf1 * 6 + a1 * 6 + dimat * 6 + bevinfo * 4 + villtan * 5 + makro * 2) / osztondijOszto;

            //Ha a kasztolást választjuk, akkor valamelyik oldalt double-é kasztoljuk, így nem csak egész része marad meg az osztásnak
            //double atlag = (sztf1 * 6 + a1 * 6 + dimat * 6 + bevinfo * 4 + villtan * 5 + makro * 2) / (double)30;
            //double atlag = (double)(sztf1 * 6 + a1 * 6 + dimat * 6 + bevinfo * 4 + villtan * 5 + makro * 2) / 30;


            Console.Write("A hallgató átlaga: ");
            Console.WriteLine(atlag);

            Console.ReadLine();
        }
    }
}
