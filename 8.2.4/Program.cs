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
            int[] result = gettingLowestAndAmountOfHisRepeats(numbers);
            Console.WriteLine("Lowest number:" +result[0] + "\n Repeats in array:" + result[1]) ;

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
        static int[] gettingLowestAndAmountOfHisRepeats(int[] table)
        {
            int[] operations = new int[2];
            //getting highest number
            int lowestNumber = table[0];
            foreach (int number in table)
            {
                if (number < lowestNumber) lowestNumber = number;
            }
            //amount of repeats
            int counterOfRepeats = 0;
            foreach (int number in table)
            {
                if (number == lowestNumber) counterOfRepeats++;
            }
            operations[0] = lowestNumber;
            operations[1] = counterOfRepeats;
            return operations;

        }
    }
}