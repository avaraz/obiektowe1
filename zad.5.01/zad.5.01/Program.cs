using System;

namespace zad._5._01
{
    class Program
    {
        static void temperatura(double f)
        {
            double c = (f - 32) / 1.8;
            Console.WriteLine("{0}F to {1}C", f, c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę w stopniach Farenheita:");
            double f = double.Parse(Console.ReadLine());
            temperatura(f);
            Console.ReadKey();
        }
    }
}
