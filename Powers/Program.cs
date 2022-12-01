using System;

namespace Powers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zakres liczb");
            int range = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj potege do sprawdzenia");
            int power = int.Parse(Console.ReadLine());
            bool isValid = true;
            List<int> powers = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                int startingNumber = i;
                while (startingNumber > 1)
                {
                    if (startingNumber % power == 0)
                    {
                        startingNumber = startingNumber / power;
                    }
                    else
                    {
                        startingNumber = 0;
                    }
                }
                if (startingNumber > 0) powers.Add(i);
            }
            showingArrayContent (powers);
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
            Console.WriteLine (txt);
        }
    }
}
