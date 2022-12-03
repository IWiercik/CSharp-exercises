using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string lokalizacja = Path.Combine(Environment.CurrentDirectory, "./\\pesel.txt");
            string[] lines = File.ReadAllLines(lokalizacja);
            List<string> correctPessels = new List<string>();
            for (int indexPesel = 0; indexPesel < lines.Length; indexPesel++)
            {
                string pesel = lines[indexPesel];
                string data = pesel.Substring(0, 5);
                string numbers = pesel[6].ToString() + pesel[7].ToString() + pesel[8].ToString();
                string gender = pesel[9].ToString();
                string isValid = pesel[10].ToString();

                int[] wages = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += int.Parse(pesel[i].ToString()) * wages[i];

                }
                int checkingIfValid = sum % 10;
                if (isValid == checkingIfValid.ToString())
                {
                    correctPessels.Add(pesel);
                }
            }
            showingArrayContent(correctPessels);
        }
        static void showingArrayContent(List<string> table)
        {
            string txt = "[";
            for (int i = 0; i < table.Count(); i++)
            {
                txt += table[i];
                if (i < table.Count() - 1)
                {
                    txt += $"{i + 1}, ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }
    }
}
