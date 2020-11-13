using System;

namespace zad._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double waga, wzrost, bmi;

            Console.WriteLine("Podaj wage w kilogramach");
            waga = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wzrost w metrach");
            wzrost = double.Parse(Console.ReadLine());

            bmi = waga / (wzrost * wzrost);

            Console.WriteLine("{0}", bmi);

            if (bmi <= 18.5)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (bmi > 18.5 && bmi < 24.99)
            {
                Console.WriteLine("Wartość prawidłowa");
            }
            else
            {
                Console.WriteLine("Nadwaga");
            }

            Console.ReadKey();
        }
    }
}
