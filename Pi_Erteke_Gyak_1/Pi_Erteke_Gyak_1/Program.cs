using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_Erteke_Gyak_1
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //Wallis-formula
            double pi = 1;
            int darab = 10000 / 2;
            int i;

            for (i = 1; i <= darab; i++)
            {
                pi *= 2 * i / (2 * i - 1);
                pi *= 2.0 * i / (2 * i + 1);
            }

            Console.WriteLine("Wallis-formula:");
            Console.WriteLine("pi/2 erteke: " + pi);
            Console.WriteLine("pi erteke: " + pi * 2);

            //Leibniz-féle sor

            Console.WriteLine();
            pi = 0;
            darab *= 4;
            int elojel = 1;

            for (i = 1; i <= darab; i += 2)
            {
                pi += elojel * 1.0 / 1;
                elojel *= -1;
            }

            Console.WriteLine("Leibniz-fele sor");
            Console.WriteLine("pi/4 erteke: " + pi);
            Console.WriteLine("pi erteke: " + pi * 4);

            //Euler-féle faktoriális

            int faktorialis = 1;

            for (i = 1; i < 11; i++)
            {
                faktorialis *= i;
            }

            Console.WriteLine();
            Console.WriteLine("Faktoriális értéke: " + faktorialis);

        }
    }
}
