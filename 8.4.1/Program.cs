using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            float floatNumber;
            Console.WriteLine("How much numbers you want to write?");
            string userInput = Console.ReadLine();
            while (!(int.TryParse(userInput, out number)))
            {
                Console.WriteLine("incorret value \n Type amount of numbers you want to write!");
                userInput = Console.ReadLine();
            }
            int amountOfUserNumbers = int.Parse(userInput);

            float[] numbers = new float[amountOfUserNumbers];
            for (int i = 0; i < amountOfUserNumbers; i++)
            {
                int counterOfNumbers = i + 1;
                Console.WriteLine("Pass your " + counterOfNumbers + " number:");
                string userInputNumber = Console.ReadLine();
                while (!(float.TryParse(userInputNumber, out floatNumber)))
                {
                    Console.WriteLine("Inncorect value! \n Pass your number!");
                    userInputNumber = Console.ReadLine();
                }
                numbers[i] = float.Parse(userInputNumber);
            }
            Console.WriteLine("Array view:");
            showingArrayContent(numbers);
            showingArrayContent(showingEvenNumbers(numbers));

        }
        static void showingArrayContent(float[] table)
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
        static float[] showingEvenNumbers(float[] tab)
        {
            float[] evenNumbersArray = new float[tab.Length];
            for (int i = 0; i < evenNumbersArray.Length; i++)
            {
                if (tab[i] % 2 == 0) evenNumbersArray[i] = tab[i];
            }
            return evenNumbersArray;
        }

    }
}