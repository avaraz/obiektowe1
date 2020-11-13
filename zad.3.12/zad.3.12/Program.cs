using System;

namespace zad._3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby. Program poda sume, gdy wpiszesz 0.");
            int liczba, suma = 0;
            liczba = int.Parse(Console.ReadLine());

            while (liczba > 0)
            {
                suma += liczba;
                liczba = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Suma liczb wynosi {0}.", suma);
        }
    }
}
