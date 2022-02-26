using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Gyakorlat_EllenBeolvas
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg;
            int bekertszam;
            bool sikeres_E;

            do
            {
                Console.WriteLine("Adjon meg egy számot 1 és 10 között:");

                do
                {
                    szoveg = Console.ReadLine();
                    sikeres_E = int.TryParse(szoveg, out bekertszam);

                    if(!sikeres_E)
                    {
                        Console.WriteLine("Nem számot adott meg.");
                    }


                } while (!sikeres_E);

            } while (bekertszam < 1 || bekertszam > 10);

            Console.WriteLine("A bekertszam értéke = " + bekertszam);

        }
    }
}
