using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecToBin(1));
        }

        static string DecToBin(int decimalValue)
        {
            string bin = "";
            int dec = decimalValue;
            while (dec > 0)
            {
                bin = bin.Insert(0, (dec % 2).ToString());
                dec = dec / 2;
            }
            return bin;
        }
    }
}
