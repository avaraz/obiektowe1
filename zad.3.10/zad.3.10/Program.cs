using System;

namespace zad._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, silnia = 1;

            Console.WriteLine("Podaj liczbę: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                silnia *= i;

            Console.WriteLine(silnia);

            Console.ReadKey();
        }
    }
}
