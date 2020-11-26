using System;

namespace zad._5._10
{
    class Program
    {
        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Oblicz(5));
        }
    }
}
