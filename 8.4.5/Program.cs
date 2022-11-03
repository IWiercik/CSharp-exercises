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
            Console.WriteLine("Array of numbers with all chars even \n");
            showingListContent(showingNumbersWithAllNumEven(numbers));

        }
        static void showingArrayContent(int[] table)
        {
            string txt = "[";
            for (int i = 0; i < table.Length; i++)
            {
                txt += table[i];
                if (i < table.Length - 1)
                {
                    txt += " | ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }
        static void showingListContent(List<int> table)
        {
            string txt = "[";
            for (int i = 0; i < table.Count; i++)
            {
                txt += table[i];
                if (i < table.Count - 1)
                {
                    txt += " | ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }
        static List<int> showingNumbersWithAllNumEven(int[] tab)
        {
            List<int> correctNumbersArray = new List<int>();
            for (int i = 0; i < tab.Length; i++)
            {
                string arrayNumber = tab[i].ToString();
                char[] eachLetterOfArrayNumber = new char[arrayNumber.Length];
                for (int j = 0; j < arrayNumber.Length; j++)
                {
                    eachLetterOfArrayNumber[j] = arrayNumber[j];
                }
                bool allLettersNum = eachLetterOfArrayNumber.All(num => num % 2 == 0);
                if (allLettersNum == true)
                {
                    correctNumbersArray.Add(int.Parse(arrayNumber));
                }
            }
            return correctNumbersArray;
        }

    }
}