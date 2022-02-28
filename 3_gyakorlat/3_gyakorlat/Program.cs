using System;
using System.Text;
using System.IO;

namespace _3_gyakorlat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg az 1. operandust!");
            int elso_operandus = egeszetbeolvas("1. operandus:");

            Console.WriteLine("Kérem adja meg az 2. operandust!");
            int masodik_operandus = egeszetbeolvas("2. operandus:");

            Console.WriteLine("Kérem adja meg a muveletet (az operátort)!");
            Console.WriteLine("A művelet:");
            string muvelet = Console.ReadLine();

            alapmuveletek(elso_operandus,masodik_operandus,muvelet);

            //2. része a feladatnak
            string valasz;

            do
            {
                Console.WriteLine("Kérem adja meg a kiszámítandó kifejezést" 
                                  + "szóközzel elválasztva!");
                Console.WriteLine("A kifejezés:");
                string kifejezes = Console.ReadLine();

                string[] eredmenytomb = kifejezes.Split(' ');

                elso_operandus = int.Parse(eredmenytomb[0]);
                muvelet = eredmenytomb[1];
                masodik_operandus = int.Parse(eredmenytomb[2]);

                alapmuveletek(elso_operandus, masodik_operandus, muvelet);

                Console.WriteLine("Szeretne még új műveletet megadni!");
                Console.WriteLine("Válasz (Igen/Nem): ");
                valasz = Console.ReadLine();

            } while (valasz.Equals("Igen"));

        }

        private static void alapmuveletek(int elso_operandus, int masodik_operandus, string muvelet)
        {
            switch(muvelet[0])
            {
                case '+':
                    Console.WriteLine("Az összeadás eredménye");
                    Console.WriteLine(elso_operandus + " + " + 
                                      masodik_operandus + " = " +
                                      (elso_operandus + masodik_operandus));
                    break;

                case '-':
                    Console.WriteLine("A(z) kivonás eredménye");
                    Console.WriteLine(elso_operandus + " - " +
                                      masodik_operandus + " = " +
                                      (elso_operandus - masodik_operandus));
                    break;

                case '*':
                    Console.WriteLine("A(z) szorzás eredménye");
                    Console.WriteLine(elso_operandus + " * " +
                                      masodik_operandus + " = " +
                                      (double)elso_operandus * masodik_operandus);
                    break;

                case '/':

                    if(masodik_operandus == 0)
                    {
                        Console.WriteLine("0-val nem lehet osztani!");
                    }

                    Console.WriteLine("Az osztás eredménye");
                    Console.WriteLine(elso_operandus + " / " +
                                      masodik_operandus + " = " +
                                      (double)elso_operandus / masodik_operandus);
                    break;

                default:
                    Console.WriteLine("Nem a 4 alapművelet (+ , - , * , /)"
                                       + "egyiket adta meg!");
                    break;

            }
        }

        private static int egeszetbeolvas(string message)
        {
            string ReadString;
            int result;
            bool successRead;

            do
            {
                Console.WriteLine("Adjon meg egy számot 1 és 100 között:");

                do
                {
                    Console.WriteLine(message);

                    ReadString = Console.ReadLine();

                    successRead = int.TryParse(ReadString, out result);

                    if (!successRead)
                    {
                        Console.WriteLine("Nem számot adott meg.");
                    }


                } while (!successRead);

            } while (result < 1 || result > 100);

            return result;
        }
    }
}
