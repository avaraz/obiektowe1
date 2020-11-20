using System;

namespace zad._4._07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] B = { { 12, 32, 8 }, { 9, 17, 11 } };

            int y = 2;
            int x = 3;
            int[,] C = new int[y, x];

            Console.WriteLine("Pierwsza macierz: \n");
            int i;
            int j = 0;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}", A[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.WriteLine("Druga macierz: \n");
            int a;
            int b = 0;
            for (a = 0; a < 2; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    Console.Write("{0,5}", B[a, b]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Suma macierzy: \n");
            int w, k;
            for (w = 0; w < 2; w++)
            {
                for (k = 0; k < 3; k++)
                {
                    C[w, k] = A[w, k] + B[w, k];
                    Console.Write("{0,5}", C[w, k]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
