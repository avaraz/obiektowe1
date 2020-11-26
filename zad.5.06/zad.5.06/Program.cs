using System;

namespace zad._5._06
{
    class Program
    {
        static void mnozenie(string[] tablica, int x)
        {
            Console.WriteLine("\nKonkatencja:");
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(tablica[i]);
                }
                Console.Write(" ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 wyrazy:");
            string[] tablica = new string[3];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = Console.ReadLine();
            }

            Console.WriteLine("Podaj mnożnik:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Twoje wyrazy:");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            mnozenie(tablica, x);
        }
    }
}