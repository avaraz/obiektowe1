using System;

namespace zad._5._01
{
    class Program
    {
        static int przedzial(int a, int b, int x)
        {
            if (a < x && x < b) return 1;
            else return 0;
        }
        static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("Podaj a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj x:");
            x = int.Parse(Console.ReadLine());

            if (przedzial(a, b, x) == 1)
                Console.WriteLine("{0} należy do przedziału ({1},{2}).", x, a, b);
            else 
                Console.WriteLine("{0} nie należy do przedziału ({1},{2}).", x, a, b);
            Console.ReadKey();
        }
    }
}
