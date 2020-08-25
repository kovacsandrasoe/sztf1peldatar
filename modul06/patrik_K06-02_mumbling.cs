using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mumbling("RqaEzty"));
            Console.ReadKey();
        }

        public static string Mumbling(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0)
                    result += "-";

                for (int j = 0; j < i+1; j++)
                {
                    if (j == 0)
                        result += char.ToUpper(s[i]);
                    else
                        result += char.ToLower(s[i]);
                }

            }

            return result;
        }
    }
}
