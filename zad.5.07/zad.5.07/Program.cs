using System;

namespace zad._5._07
{
    class Program
    {
        static void ciag(int x, int n)
        {
            int wzor = (2 * x + 1 + n) * n / 2;
            Console.WriteLine("Wynik: {0}", wzor);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj x dla ciągu W = (x+1) + (x+2) + (x+3) +.......+ (x+n)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj n dla W = (x+1) + (x+2) + (x+3) +.......+ (x+n)");
            int n = int.Parse(Console.ReadLine());

            ciag(x, n);
        }
    }
}