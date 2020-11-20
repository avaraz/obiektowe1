using System;

namespace zad._4._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { -19, 34, -23, 54, 31, 71, 28, -9, -2, 10};
            int[] tab2 = new int[tab1.Length];

            for (int i = tab1.Length - 1; i >= 0; i--)
                if (tab1[i] > 0)
                    tab2[tab1.Length - i - 1] = tab1[i];

            for (int i = tab2.Length - 1; i >= 0; i--)
                if (tab2[i] > 0)
                    Console.WriteLine(tab2[i]);

            Console.ReadKey();
        }
    }
}
