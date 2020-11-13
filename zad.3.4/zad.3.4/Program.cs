using System;

namespace zad._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe A.");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe B.");
            double b = double.Parse(Console.ReadLine());

            double c;

            Console.WriteLine("Wybierz operacje (+,-,*,/)");
            string symbol = Console.ReadLine();
            switch (symbol)
            {
                case "+":
                    c = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a,b,c);
                    break;

                case "-":
                    c = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, c);
                    break;

                case "*":
                    c = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, c);
                    break;

                case "/":
                    c = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, c);
                    break;

                default:
                    Console.WriteLine("Niepoprawny znak.");
                    break;
            }
        }
    }
}
