using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            List<int> numbers = new List<int>();
            bool endOfInputNumbers = false;
            Console.WriteLine("Type your numbers, if you want to stop type 'end'");
            while (!endOfInputNumbers)
            {
                Console.WriteLine("Type number:");
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out number);
                if (isNumber)
                {
                    numbers.Add(int.Parse(userInput));
                }
                else
                {
                    if (userInput == "end")
                    {
                        endOfInputNumbers = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrent value");
                    }
                }
            }
            Console.WriteLine("View of your array:");
            showingArrayContent(numbers);
            Console.WriteLine("Your lowest number is:" + gettingLowestNumber(numbers));
        }
        static void showingArrayContent(List<int> table)
        {
            string txt = "[";
            for (int i = 0; i < table.Count; i++)
            {
                txt += table[i];
                if (i < table.Count - 1)
                {
                    txt += ", ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }
        static int gettingLowestNumber(List<int> table)
        {
            int lowestNumber = table[0];
            foreach (int number in table)
            {
                if (number < lowestNumber)
                {
                    lowestNumber = number;
                }
            }
            return lowestNumber;
        }
    }
}