using System;

namespace zad._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę A.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę B.");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę C.");
            int c = int.Parse(Console.ReadLine());

            if (a > b && b > c)
                Console.WriteLine("Liczba {0) jest największa.", a);
            else
                if (b > a && a > c)
                Console.WriteLine("Liczba {0} jest najwieksza.", b);
            else
                Console.WriteLine("Liczba {0} jest najwieksza.", c);
   
        }
    }
}
