using System;

namespace zad._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;

            Console.WriteLine("Podaj A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj B");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj C");
            c = int.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            Console.WriteLine(delta);


            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Brak miejsc zerowych.");
            }

            Console.ReadKey();
        }
    }
}
