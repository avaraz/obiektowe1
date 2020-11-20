using System;

namespace zad._4._09
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = 0;
            string tekst;
            Console.WriteLine("Podaj tekst: ");
            tekst = Console.ReadLine();

            if (tekst.Length > 0)
            {
                for (int i = 0; i < tekst.Length; i++)
                {
                    if (tekst[i] == ' ')
                    {
                        ilosc++;
                    }
                }
                Console.WriteLine("Ilość wyrazów w tekście to: {0}", ilosc + 1);
            }
            else {
                ilosc = 0;
                Console.WriteLine("Ilość wyrazów w tekście to: {0}", ilosc);
            }
        } 
    }
}
