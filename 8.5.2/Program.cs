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
                float counterOfNumbers = i + 1;
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
            Console.WriteLine("Array after transformation:");
            showingListContent(showingNumWithSquaredIndex(numbers));

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
        static void showingListContent(List<float> table)
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
        static List<float> showingNumWithSquaredIndex(float[] tab)
        {
            List<float> transformedArray = new List<float>();
            int squareNumb = 1;
            for (int numIndex = 0; numIndex < tab.Length; numIndex++)
            {
                if (numIndex == squareNumb * squareNumb)
                {
                    transformedArray.Add(tab[numIndex]);
                    squareNumb++;
                }

            }
            return transformedArray;

        }


    }
}