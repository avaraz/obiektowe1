using System;

namespace zad._5._05
{
    class Program
    {
        static void rysuj(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Szerokość:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            rysuj(a,b);
            Console.WriteLine();
            rysuj(b, a);
        }
    }
}
