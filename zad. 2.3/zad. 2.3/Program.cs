using System;
/*Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić
użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach.*/
namespace zad._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double waga, wzrost, bmi;

            Console.WriteLine("Obliczanie BMI.");
            Console.WriteLine("Podaj wagę w kilogramach:");
            waga = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wzrost w metrach:");
            wzrost = double.Parse(Console.ReadLine());

            bmi = waga / (wzrost * wzrost);

            Console.WriteLine(Math.Round(bmi, 2));

            Console.ReadKey();
        }
    }
}
