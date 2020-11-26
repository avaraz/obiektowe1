using System;

namespace _5._03
{
    class Program
    {
        static void Przesun(ref int[,] tab1)
        {

            int x, y;
            int[,] wektor = new int[1, 2] { { 3, 2 } };
            for (x = 0; x < 1; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    tab1[x, y] = tab1[x, y] + wektor[x, y];
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] tab1 = new int[1, 2];
            Console.WriteLine("Podaj dwie początkowe współrzędne punktu A: ");
            for (int a = 0; a < 1; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    tab1[a, b] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Współrzędne po przesunięciu o wektor[3,2]:");
            Przesun(ref tab1);
            foreach (int x in tab1)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
