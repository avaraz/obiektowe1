using System;

namespace zad._4._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, suma = 0;
            int[,] tab = new int[5, 5];

            Console.Write("Macierz 5x5. \n");
            Console.Write("Podaj elementy macierzy: \n");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("[{0},{1}] : ", i, j);
                    tab[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\n Twoja macierz to: \n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 5; j++)
                    Console.Write("{0,3}", tab[i, j]);
            }

            for (i = 0; i < 5; i++)
            {
            suma = suma + tab[i, i];
            }
            Console.Write("\n Suma elementów na przekątnej to: {0} \n", suma);
        }
    }
}
