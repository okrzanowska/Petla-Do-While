using System;
namespace PetlaDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczby całkowite z przedziału od 1 do 20 podniesione do kwadratu:");

            int number = 1;
            do
            {
                Console.WriteLine(Math.Pow(number, 2));
            } while (number++ <= 20);
        }
    }
}