using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OctToBin("777");
        }
        static void OctToBin(string octValue)
        {
            string result = "";
            for (int i = 0; i < octValue.Length; i++)
            {
                char character = (char)octValue[i];
                int decValue = character - '0';
                string bin = DecToBin(decValue);
                while (bin.Length < 3)
                {
                    bin = "0" + bin;
                }
                result += bin;
            }
            Console.WriteLine(result);
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