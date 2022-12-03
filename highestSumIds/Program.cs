using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Path.Combine(Environment.CurrentDirectory, "./\\identyfikator.txt");
            string[] lines = File.ReadAllLines(file);
            // showingArrayContent((lines));
            showingArrayContent(highestSumIds(lines));
        }
        static List<string> highestSumIds(string[] array)
        {
            List<int> idsSum = new List<int>();
            List<string> highestSumItems = new List<string>();
            for (int i = 0; i < array.Length; i++) // Filling series and ids array
            {
                string item = array[i];
                string id = item.Substring(3);
                int sum = 0;
                for(int j = 0 ; j< id.Length; j++){ // Getting sum of single item
                    int singleNum = int.Parse(id[j].ToString());
                    sum += singleNum;
                }
                idsSum.Add(sum);

            }
            int highestValue = idsSum.Max();
            for( int sumIndex = 0; sumIndex < idsSum.Count();sumIndex++){
                if(idsSum[sumIndex] == highestValue) highestSumItems.Add(array[sumIndex]);
            }
            return highestSumItems;
        }
        static void showingArrayContent(List<string> table)
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
    }
}