using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("How much numbers you want to write?");
            string userInput = Console.ReadLine();
            while (!(int.TryParse(userInput, out number)))
            {
                Console.WriteLine("incorret value \n Type amount of numbers you want to write!");
                userInput = Console.ReadLine();
            }
            int amountOfUserNumbers = int.Parse(userInput);

            int[] numbers = new int[amountOfUserNumbers];
            for (int i = 0; i < amountOfUserNumbers; i++)
            {
                int counterOfNumbers = i + 1;
                Console.WriteLine("Pass your " + counterOfNumbers + " number:");
                string userInputNumber = Console.ReadLine();
                while (!(int.TryParse(userInputNumber, out number)))
                {
                    Console.WriteLine("Inncorect value! \n Pass your number!");
                    userInputNumber = Console.ReadLine();
                }
                numbers[i] = int.Parse(userInputNumber);
            }
            Console.WriteLine("Array view:");
            showingArrayContent(numbers);
            int secondLowestNumber = gettingSecondLowest(numbers);
            Console.WriteLine("Second lowest number is:" + secondLowestNumber);
            Console.WriteLine("Number repeated: " + findingRepeatsOfNumber(numbers, secondLowestNumber) + " times");
        }
        static void showingArrayContent(int[] table)
        {
            string txt = "[";
            for (int i = 0; i < table.Length; i++)
            {
                txt += table[i];
                if (i < table.Length - 1)
                {
                    txt += ", ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }
        static int gettingSecondLowest(int[] table)
        {
            int lowestNumber = table.Min();
            int secondLowestNumber = table.Max();
            //Getting secondHighest
            foreach (int number in table)
            {
                if (number < secondLowestNumber && number > lowestNumber)
                {
                    secondLowestNumber = number;
                }
            }
            return secondLowestNumber;

        }
        static int findingRepeatsOfNumber(int[] table, int number)
        {
            int repeats = 0;
            foreach (int arrayNumber in table)
            {
                if (arrayNumber == number)
                {
                    repeats++;
                }
            }
            return repeats;
        }
    }
}