using System;

namespace zad._3._14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Przedzial od 1 do n. Podaj N: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int suma = 0;
                for (int j = 1; j < i; j++)
                    if (i % j == 0)
                        suma += j;
                if (suma == i)
                    Console.WriteLine("Liczba {0} jest liczba doskonala.", i);
            }
        }
    }
}
