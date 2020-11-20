using System;

namespace zad._4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj datę w formacie dd-mm-yyyy");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            int miesiac = data.Month;

            Console.WriteLine("Miesiąc to: ");

            switch (miesiac)
            {
                case 1:
                    Console.WriteLine("Styczeń");
                    break;
                case 2:
                    Console.WriteLine("Luty");
                    break;
                case 3:
                    Console.WriteLine("Marzec");
                    break;
                case 4:
                    Console.WriteLine("Kwiecień");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Czerwiec");
                    break;
                case 7:
                    Console.WriteLine("Lipiec");
                    break;
                case 8:
                    Console.WriteLine("Sierpień");
                    break;
                case 9:
                    Console.WriteLine("Wrzesień");
                    break;
                case 10:
                    Console.WriteLine("Październik");
                    break;
                case 11:
                    Console.WriteLine("Listopad");
                    break;
                case 12:
                    Console.WriteLine("Grudzień");
                    break;
            }

        }
        
    }
}
