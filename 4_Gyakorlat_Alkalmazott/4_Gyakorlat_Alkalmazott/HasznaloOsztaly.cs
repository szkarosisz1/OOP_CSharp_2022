using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Gyakorlat_Alkalmazott
{
    internal class HasznaloOsztaly
    {
        static void Main(string[] args)
        {
            //int[] tomb = new int[2]; -> Elemi típus

            //1.feladat a) része
            Alkalmazott alkalmazott = new Alkalmazott(); // -> Referencia típus

            Alkalmazott masikAlkalmazott;
            masikAlkalmazott = new Alkalmazott();

            /*alkalmazott._nev = "Kovacs Bela";
            alkalmazott._fizetes = 100000;*/
            alkalmazott.SetNev("Kovacs Bela");
            alkalmazott.SetFizetes(100000);

            Console.WriteLine($"Név: {alkalmazott.GetNev()}");
            Console.WriteLine($"Fizetés: {alkalmazott.GetFizetes()}");
            Console.WriteLine(alkalmazott.FizetesHataronBelulVan(50000,200000));

            alkalmazott.FizetestNovel(50000);

            Console.WriteLine(alkalmazott.AlkalmazottKiir());

            Alkalmazott[] alkalmazottak = new Alkalmazott[5];
            Random veletlenObjektum = new Random();

            for (int i = 0; i < alkalmazottak.Length; i++)
            {
                alkalmazottak[i] = new Alkalmazott();
                alkalmazottak[i].SetNev("SZSZ" + (i + 1));
                alkalmazottak[i].SetFizetes(veletlenObjektum.Next(9000000));
                Console.WriteLine(alkalmazottak[i].AlkalmazottKiir());
            }

            int maxFizetesuAlkIndexe = 0;

            for (int i = 0; i < alkalmazottak.Length; i++)
            {
                if (alkalmazottak[i].FizetesNagyobbMint(alkalmazottak[maxFizetesuAlkIndexe]))
                {
                    maxFizetesuAlkIndexe = i;
                }
            }

            Console.WriteLine(alkalmazottak[maxFizetesuAlkIndexe]);
        }

    }
}
