using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isProgramOver = false;
            while (!isProgramOver)
            {
                int firstNum = 0;
                string firstInput = "";
                Console.WriteLine("Podaj swoja pierwsza liczbe");
                firstInput = Console.ReadLine();
                while (!(int.TryParse(firstInput, out firstNum)))
                {
                    Console.WriteLine("Podaj poprawna wartość pierwszej liczby");
                    firstInput = Console.ReadLine();
                }
                int secondNum = 0;
                string secondInput = "";
                Console.WriteLine("Podaj swoja druga liczbe");
                secondInput = Console.ReadLine();
                while (!(int.TryParse(secondInput, out secondNum)))
                {
                    Console.WriteLine("Podaj poprawna wartość drugiej liczby");
                    secondInput = Console.ReadLine();
                }
                char operation;
                string thirdInput = "";
                string availableOperations = "+/-:*x";
                Console.WriteLine("Podaj operacje matematyczna");
                thirdInput = Console.ReadLine();
                while (!availableOperations.Contains(thirdInput))
                {
                    Console.WriteLine("Podaj poprawna operacje");
                    thirdInput = Console.ReadLine();
                }
                

            }
        }
    }
}