using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultOfProgram = 0;
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
                thirdInput = Console.ReadLine().ToLower();
                while (!availableOperations.Contains(thirdInput))
                {
                    Console.WriteLine("Podaj poprawna operacje");
                    thirdInput = Console.ReadLine().ToLower();
                }
                operation = Convert.ToChar(thirdInput);
                switch (operation)
                {
                    case '+':
                        resultOfProgram = firstNum + secondNum;
                        break;
                    case '-':
                        resultOfProgram = firstNum - secondNum;
                        break;
                    case '/':
                    case ':':
                        resultOfProgram = firstNum / secondNum;
                        break;
                    case '*':
                    case 'x':
                        resultOfProgram = firstNum * secondNum;
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
                Console.WriteLine("--------WYNIK PROGRAMU--------");
                Console.WriteLine($"Pierwsza liczba:{firstNum}");
                Console.WriteLine($"Druga liczba:{secondNum}");
                Console.WriteLine($"Operacja:{operation}");
                Console.WriteLine($"Wynik:{resultOfProgram}");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Jesli chcesz skonczyc wpisz 'KONIEC' w przeciwnym razie wpisz cokolwiek innego.");
                string fourthInput = Console.ReadLine();
                if (fourthInput == "KONIEC") isProgramOver = true;
            }
        }
    }
}