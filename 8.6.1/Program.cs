using System;
namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type the range of numbers");
            int numRange = int.Parse(Console.ReadLine());
            List<int> arrayWithFilledNum = fillTheArayWithNum(numRange);
            // for (int index = 1; index < arrayWithFilledNum.Count(); index++) // Loop for every lowest index 2,3,5,7 
            // {
            //     int lowestIndex = arrayWithFilledNum[index];
            //     // Console.WriteLine("Lowest index:" + lowestIndex);
            //     for (int multiplier = 2; multiplier < arrayWithFilledNum.Count(); multiplier++)
            //     {
            //         // Console.WriteLine("Multiplier:"+  multiplier*lowestIndex);
            //         if ((lowestIndex * multiplier) % lowestIndex == 0) arrayWithFilledNum.Remove(lowestIndex * multiplier);
            //     }
            // }
            for (int index = 1; index < arrayWithFilledNum.Count(); index++) // Loop for every lowest index 2,3,5,7 
            {
                int lowestIndex = arrayWithFilledNum[index];
                for (int multiplier = 2; multiplier*lowestIndex <= arrayWithFilledNum.Last(); multiplier++)
                {
                    if ((lowestIndex * multiplier) % lowestIndex == 0) arrayWithFilledNum.Remove(lowestIndex * multiplier);
                }
            }
            showingListContent(arrayWithFilledNum);
            Console.WriteLine(arrayWithFilledNum.Count());
        }
        static List<int> fillTheArayWithNum(int range)
        {
            List<int> array = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                array.Add(i);
            }
            return array;

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

    }

}