using System;

namespace zad._4._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak duża ma być tablica:");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            int[] tab2 = new int[tab1.Length];

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tab1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n Tablica nr 1:");
            Array.Copy(tab1, 0, tab2, 1, tab1.Length - 1);
            Array.Copy(tab1, tab1.Length - 1, tab2, 0, 1);
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine(tab1[i]);
            }
            Console.WriteLine("\n Tablica nr 2:");
            foreach (int x in tab2)
                Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
