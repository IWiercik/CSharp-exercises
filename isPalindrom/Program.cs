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
            showingArrayContent(isPalindrom(lines));
        }
        static List<string> isPalindrom(string[] array)
        {
            List<string> palindroms = new List<string>();
            for (int i = 0; i < array.Length; i++) // Filling series and ids array
            {
                string item = array[i];
                string id = item.Substring(3);
                string serie = item.Substring(0,3);
                if((checkingIfElementIsPalindrom(id) || checkingIfElementIsPalindrom(serie)) == true) palindroms.Add(item);
            }
            return palindroms;

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
        static bool checkingIfElementIsPalindrom(string element){
            bool isValid = true;
            for(int i =0 ; i < element.Length; i++){
                if(element[i] != element[element.Length-i-1]) isValid = false;
            }
            return isValid;
        }
    }
}