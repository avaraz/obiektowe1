using System;

namespace zad._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę B:");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("Liczba B jest dzielnikiem liczby A.");
            }
            else
            {
                Console.WriteLine("Liczba B nie jest dzielnikiem liczby A.");
            }
        }
    }
}
