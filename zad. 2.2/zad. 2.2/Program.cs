using System;
/*Napisz program, który oblicza deltę dla równania kwadratowego ax^2+bx+c=0.
Program ma prosić użytkownika o podanie współczynników równania a, b oraz c. 
Wzór: delta=b^2-4ac.*/
namespace zad._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Obliczanie delty.");
            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            Console.WriteLine("Delta wynosi: ");
            Console.WriteLine(Math.Round(delta, 2));

            Console.ReadKey();

        }
    }
}
