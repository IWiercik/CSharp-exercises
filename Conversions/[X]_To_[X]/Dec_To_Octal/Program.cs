using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decToOctal(8);
        }
        static void decToOctal(int decValue)
        {
            int startingValue = decValue;
            string result = "";
            while (startingValue > 0)
            {
                result = startingValue % 8 + result;
                startingValue = startingValue / 8;
            }
            Console.WriteLine(result);
        }
    }
}