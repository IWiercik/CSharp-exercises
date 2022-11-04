using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] array = { 5, 4, 3, 2, 1, 100, 300, 2, 4,55,23,24,12,312,423,345,123,654,231 };
            int[] secondArray = { 3, 1, 0, 7, 9, 1, 3, 4, 5, 2, 5,523,534,21,43,543,123,654,214 };

            // FIRST SORT
            watch.Start();
            firstSortingArray(array);
            firstSortingArray(secondArray);
            watch.Stop();
            // * showing result* 
            Console.WriteLine("\n[FIRST] firstArray view:"); showingArrayContent(firstSortingArray(array));
            Console.WriteLine("[FIRST] secondArray view:"); showingArrayContent(firstSortingArray(secondArray));
            Console.WriteLine("First sort execute time:" + watch.ElapsedMilliseconds + "ms");
            watch.Restart();

            // SECOND SORT
            watch.Start();
            secondSortingArray(array);
            secondSortingArray(secondArray);
            watch.Stop();
            // * showing result* 
            Console.WriteLine("\n[SECOND] firstArray view:"); showingArrayContent(secondSortingArray(array));
            Console.WriteLine("[SECOND] secondArray view:"); showingArrayContent(secondSortingArray(secondArray));
            Console.WriteLine("Second sort execute time:" + watch.ElapsedMilliseconds + "ms");
            watch.Restart();

            // THIRD SORT
            watch.Start();
            thirdSortingArray(array);
            thirdSortingArray(secondArray);
            watch.Stop();
            // * showing result* 
            Console.WriteLine("\n[THIRD] firstArray view:"); showingArrayContent(thirdSortingArray(array));
            Console.WriteLine("[THIRD] secondArray view:"); showingArrayContent(thirdSortingArray(secondArray));
            Console.WriteLine("Third sort execute time:" + watch.ElapsedMilliseconds + "ms");
            watch.Restart();


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
        static int[] thirdSortingArray(int[] tab)  // 3 option better optimalization, considering the "fool operation"
        {
            int foolIterate;
            int[] sortedArray = tab;
            for (int j = 1; j < sortedArray.Length; j++)
            {
                foolIterate = 1;
                for (int i = 0; i < tab.Length - j; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        foolIterate = 0;
                        int temp = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = temp;
                    }
                    if (foolIterate == 1) break;
                }
            }
            return sortedArray;
        }
        static int[] secondSortingArray(int[] tab)  // 2 option better optimalization, considering the highest number reducing amount of  sorting by i-j
        {
            int[] sortedArray = tab;
            for (int j = 1; j < sortedArray.Length; j++)
            {
                for (int i = 0; i < tab.Length - j; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        int temp = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = temp;
                    }
                }
            }
            return sortedArray;
        }
        static int[] firstSortingArray(int[] tab)  // 1 option bad optimalization
        {
            int[] sortedArray = tab;
            for (int j = 0; j < sortedArray.Length - 1; j++)
            {
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        int temp = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = temp;
                    }
                }
            }
            return sortedArray;
        }

    }
}