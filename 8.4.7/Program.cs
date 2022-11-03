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
            Console.WriteLine("Array after transformation:");
            showingArrayContent(addingToEvenNumHundred(numbers));

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
        static int[] addingToEvenNumHundred(int[] tab)
        {
            int[] transformedArray = new int[tab.Length];
            for (int i = 0; i < transformedArray.Length; i++)
            {
                if (tab[i] % 2 == 0) { transformedArray[i] = tab[i] + 100; } else { transformedArray[i] = tab[i]; }
            }
            return transformedArray;
        }

    }
}