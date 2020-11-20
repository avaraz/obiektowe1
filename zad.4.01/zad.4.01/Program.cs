using System;

namespace zad._4._01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj jak duża ma być tablica:");
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                liczby[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i] + ", ");
            }
            Console.ReadKey();
        
        }
    }
}
