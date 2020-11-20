using System;

namespace zad._4._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int i;
            int j;
            int k;
            int[] tab;
            tab = new int[100];

            Console.WriteLine("Tablica z losowymi wartościami: ");

            for (i = 0; i < 100; i++)
            {
                tab[i] = rand.Next(1, 1000);
                Console.Write("{0,10}", tab[i]);
            }

            Console.WriteLine("\n Liczby pierwsze w tym zbiorze to: ");

            int suma = 0;
            for (j = 0; j < tab.Length; j++)
            {
                for (k = 2; k < tab[j]; k++)

                    if (tab[j] % k == 0)
                    {

                        tab[j] = 0;
                        break;
                    }
                if (k == tab[j])
                    Console.Write("\n{0,10}", tab[j]);
                {
                    if (tab[j] > 0)
                        tab[j] = 0 + 1;
                    suma = suma + tab[j];

                }
            }
            Console.WriteLine("\n W powyższym zakresie znajduje sie {0} liczb pierwszych.", suma);


            Console.ReadKey();
        }
    }
}
