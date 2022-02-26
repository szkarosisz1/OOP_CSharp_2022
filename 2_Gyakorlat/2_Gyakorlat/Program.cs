using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Gyakorlat
{
    class Program
    {
        static void Main(string[] args)
        {
            int also_hatar = 1, felso_hatar = 100;
            int darab = 0;
            int i, j;
            double pi = 3.1415;

            Console.WriteLine("pi értéke: {0:N2}",pi);

            Console.WriteLine("Szöveg: "+", valami, " + darab);
            Console.WriteLine("Also: {0}, felso: {1}", also_hatar + 1, felso_hatar);
            Console.WriteLine($"pi: {pi:N3}");                  //ajánlott a használata

            Console.WriteLine("Ikerprímek:");

            //for ciklus használata
            for (i = also_hatar; i < felso_hatar; i++)
            {
                bool i_prime = PrimszamE(i);

                for (j = i + 1; j <= felso_hatar; j++)
                {
                    if(i_prime && PrimszamE(j))
                    {
                        if(j - i == 2)
                        {
                            darab++;
                            Console.WriteLine(i + ", " + j);
                        }
                    }
                }
            }

            Console.WriteLine($"{darab} ikerprím van a megadott számok között.");

        }

        public static bool PrimszamE(int szam)
        {
            if(szam < 2)
            {
                return false;
            }

            for (int i = 2; i <= szam / 2; i++)
            {
                if(szam % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool PrimszamEa(int i)
        {
            throw new NotImplementedException();
        }
    }
}
