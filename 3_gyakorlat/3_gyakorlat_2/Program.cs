using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_gyakorlat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meret = 10;
            int[] egesztomb = new int[meret];

            double[] valostomb = new double[meret];

            FeltoltEgeszTomb(egesztomb);

            ListazEgeszTomb(egesztomb);

            LegnagyobbParosSzam_(egesztomb);

            MegszamolNegyzetSzamokat(egesztomb);

            FeltoltValosTomb(valostomb);
        }

        private static void FeltoltValosTomb(double[] valostomb)
        {
            Random VeletlenObjektum = new Random();

            for (int i = 0; i < valostomb.Length; i++)
            {
                double valosVeletlenSzam = VeletlenObjektum.NextDouble() * 50 + 1;

            }
        }

        private static bool NegyzetszamE(int egeszSzam)
        {
            if(egeszSzam == 1)
            {
                return true;
            }

            for (int i = 0; i < egeszSzam / 2; i++)
            {
                if (i * i == egeszSzam)
                    return true;
            }

            return false;
        }

        private static void MegszamolNegyzetSzamokat(int[] tomb)
        {
            int negyzetszamokDarabszama = 0;

            foreach (int elem in tomb)
            {
                if(NegyzetszamE(elem))
                {
                    negyzetszamokDarabszama++;
                }    
            }

            
        }

        private static void LegnagyobbParosSzam_(int[] tomb)
        {
            bool talaltParosSzamot = false;
            int maximalisIndex = 0;

            foreach (var elem in tomb)
            {

                if (elem % 2 == 0)
                {
                    talaltParosSzamot = true;

                    if (elem > maximalisIndex)
                        maximalisIndex = elem;
                }
            }

            
        }


        private static void ListazEgeszTomb(int[] tomb)
        {
            foreach (var elem in tomb)
            {

            }
        }

        private static void FeltoltEgeszTomb(int[] tomb)
        {
            Random veletlenObjektum = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = veletlenObjektum.Next(50) + 1;
            }

        }
    }
}
