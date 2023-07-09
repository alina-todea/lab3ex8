using System;

namespace Lab3ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, 
             va afisa urmatoarea piramida a numerelor:
             */

            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());

            AfisarePiramida(4);

        }

        static void AfisarePiramida(int n)
        {

            if (n<=0)
            {
                return;
            }

            
            
            for (int i = 0; i <= n - 1; i++)

            {
                Console.Write(n);

            }
            Console.WriteLine();

            AfisarePiramida(n - 1);



        }
    }
}
