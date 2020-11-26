using System;

namespace zad._5._08
{
    class Program
    {
        static void suma(string liczba)
        {
            int suma = 0;
            for (int i = 0; i < (liczba.Length); i++)
            {
                suma = suma + int.Parse(liczba[i].ToString());
            }
            Console.WriteLine("Suma cyfr liczby {0} wynosi {1}", liczba, suma);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą, wielocyfrową.");
            string liczba = Console.ReadLine();
            suma(liczba);
        }
    }
}
