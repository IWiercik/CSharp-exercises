using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            octalToDec(140);
        }
        static void octalToDec(int octValue)
        {
            string startingValue = octValue.ToString();
            int result = 0;
            for (int i = 0; i < startingValue.Length; i++)
            {
                result += (int)(Math.Pow(8, startingValue.Length - i - 1) * (startingValue[i]-'0'));
            }
            Console.WriteLine(result);
        }
    }
}