using System;

namespace zad._3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int suma = 0;

            Console.WriteLine("Podaj długość ciągu: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                suma = -n / 2;

            else
                suma = (-n / 2) + (n);

            Console.WriteLine("Wynik ciągu to {0}.", suma);
        }
    }
}
