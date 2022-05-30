using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var losowa = random.Next(0, 100);
            //Console.WriteLine($"Wylosowana to: {liczba}");
            Console.WriteLine("Let's play a game!");
            Console.WriteLine("Zgadnij wylosowana liczbę");
            
            int i = 0;
            while (true)
            {
                i++;
                var num = getNum();
                if (num == losowa)
                {
                    Console.WriteLine($"Wylosowana liczba to {losowa}. Zgadłeś za {i} razem!");
                }
                else if (num < losowa)
                {
                    Console.WriteLine("Wylosowana liczba jest wieksza!");
                }
                else
                {
                    Console.WriteLine("Wylosowana liczba jest mniejsza!");
                }
            }
            Console.ReadLine();
        }

        private static int getNum()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int num) || num < 0 || num > 100)
                {
                    Console.WriteLine("Podałeś nieprawidlowe dane. Podaj inna liczbę");
                    continue;
                }
                return num;
            }
        }
    }
}
