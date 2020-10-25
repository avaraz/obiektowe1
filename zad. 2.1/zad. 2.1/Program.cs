using System;

/*Napisz program przeliczający temperaturę w stopniach Celsjusza na temperaturę w
stopniach Fahrenheita. Program ma prosić użytkownika o podanie temperatury w stopniach
Celsjusza.*/

namespace zad._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celcjusza:");
            C = double.Parse(Console.ReadLine());
            F = 32.0 + (9.0 / 5.0 * C);
            Console.WriteLine(Math.Round(F,2));
            Console.ReadKey();
        }

    }
}
