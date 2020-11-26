using System;

namespace zad._5._04
{
    class Program
    {
        static void mnozenie(int[] liczby, int x)
        {
            Console.WriteLine("\n Po mnożeniu:");
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = liczby[i] * x;
                Console.Write(liczby[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 5 liczb:");
            int[] liczby = new int[5];

            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Podaj mnożnik:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Przed mnożeniem:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i] + " ");
            }

            mnozenie(liczby, x);
        }
    }
}
