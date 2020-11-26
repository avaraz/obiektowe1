using System;

namespace zad._5._09
{
    class Program
    {
        static int rekurencja(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return rekurencja(n - 1) + rekurencja(n - 2);
        }

        static int iteracja(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                b += a;
                a = b - a;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Podaj, ktory wyraz ciagu Fibonacciego obliczyc");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} wyraz ciagu Fibonacciego: {1}", n, rekurencja(n));
            Console.WriteLine("{0} wyraz ciagu Fibonacciego: {1}", n, iteracja(n));
        }
    }

}
