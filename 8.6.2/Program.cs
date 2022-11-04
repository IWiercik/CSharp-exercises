using System;
namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type the range of numbers");
            int numRange = int.Parse(Console.ReadLine());
            showingArrayContent(fibonaci(numRange));
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
        static int[] fibonaci(int range)
        {
            int[] array = new int[range];
            for (int i = 0; i <= range; i++)
            {
                if (i == 0)
                {
                    array[i] = 0;
                }
                else if (i == 1)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = array[i - 2] + array[i - 1];
                }
            }
            return array;
        }

    }

}