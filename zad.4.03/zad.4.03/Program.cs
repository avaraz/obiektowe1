using System;

namespace zad._4._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak duża ma być tablica:");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tab1[i] = int.Parse(Console.ReadLine());
            }

                int max = tab1[0];
            for (int j = 0; j < tab1.Length; j++)
            {
                if (tab1[j] > max)
                {
                    max = tab1[j];
                }
            }
            Console.WriteLine("Najwieksza wartosc to {0},a jej index to {1}", max, Array.IndexOf(tab1, max));

            int min = tab1[0];
            for (int k = 0; k < tab1.Length; k++)
            {
                if (tab1[k] < min)
                {
                    min = tab1[k];
                }
            }
            Console.WriteLine("Najmniejsza wartosc tablicy to: {0},a jej index to {1}", min, Array.IndexOf(tab1, min));

            int suma = 0;
            double srednia = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                suma = suma + tab1[i];
                srednia = (double)suma / tab1.Length;
            }
            Console.WriteLine("Srednia wartosc wszystkich elementow to: {0}", srednia);

            int[] dodatnie = new int[tab1.Length];

            for (int i = tab1.Length - 1; i >= 0; i--)
                if (tab1[i] > 0)
                    dodatnie[tab1.Length - i - 1] = tab1[i];

            int sumaW = 0;
            for (int i = 0; i < dodatnie.Length; i++)
            {
                int ileW = 0;
                if (dodatnie[i] > 0) ileW++;

                sumaW = sumaW + ileW;
            }
            Console.WriteLine("W tab1 znajduja sie {0} wartosci dodatnie.", sumaW);
            Console.ReadKey();
        }
    }
}
