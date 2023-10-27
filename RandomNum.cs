using System;

namespace RandomNumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            int random = rnd.Next(1,11);
            int userNum = 0, counter = 0;
            bool valid = false;
            bool[] Array = new bool[10];
            Console.Title = "Zgadnij liczbe";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ZGADNIJ LICZBE OD 1 DO 10");
            do
            {
                do
                {
                    Console.WriteLine("Podaj liczbe: ");
                    valid= int.TryParse(Console.ReadLine(), out userNum);
                    if (valid == false)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Nie podano liczby, podaj prawidlowa wartosc!");
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    }
                } while (!valid);
                if (userNum < 1 || userNum > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nie podano prawidlowej liczby, podaj liczbe z zakresu 1-10!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    continue;
                }
                if (Array[userNum - 1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podano juz ta liczbe");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    continue;
                }
                else
                {
                    Array[userNum - 1] = true;
                }
                if (random < userNum)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Wylosowana liczba jest mniejsza od twojej");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (random > userNum)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Wylosowana liczba jest wieksza od twojej");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                counter++;


            }
            while (userNum != random);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"BRAWO! Zgadles za {counter} razem.");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}