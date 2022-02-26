using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Gyakorlat_Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 20, 20, 40, 56, 67, 30, 76, 34, 97, 100 };
            int[] tomb2 = { 10, 20, 30, 32, 31, 62, 70, 78, 80, 97 };

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            int size = 10;
            int[] tomb3 = new int[size];

            //Feltölt metódus
            Feltolt(tomb3);

            //Listaz metódus
            Listaz(tomb3);

            //ForditottListazas metódus
            ForditottListazas(tomb3);

            Console.WriteLine();
            Console.WriteLine($"A tömbelemek átlaga: {Atlag(tomb3)}");

            Console.WriteLine();
            Console.WriteLine($"A tömb minimuma: {MinimalisIndex(tomb3)}");

        }


        public static int MinimalisIndex(int[] array)
        {
            int minimalisIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < array[minimalisIndex])
                    minimalisIndex = i;
            }

            return minimalisIndex;
        }

        public static double Atlag(int[] array)
        {
            double osszeg = 0;

            foreach (var item in array)
            {
                osszeg += item;
            }

            return osszeg / array.Length;
        }

        public static void ForditottListazas(int[] array)
        {
            Console.Write("Fordítva: ");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + ", ");
            }
        }

        public static void Listaz(int[] array)
        {
            Console.WriteLine();
            Console.Write("Tombelemek: ");

            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
        }

        public static void Feltolt(int[] array)
        {
            Random random = new Random();
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(50) + 1;
                Console.WriteLine(array[i]);
            }
        }
    }
}
