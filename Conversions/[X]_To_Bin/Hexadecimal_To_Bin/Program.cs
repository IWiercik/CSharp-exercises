using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HexToBin("2F");
        }
        static void HexToBin(string hexValue)
        {
            string result = "";
            for (int i = 0; i < hexValue.Length; i++)
            {
                char character = (char)hexValue[i];
                int decValue = 0;
                switch (character)
                {
                    case 'A':
                        decValue = 10;
                        break;
                    case 'B':
                        decValue = 11;
                        break;
                    case 'C':
                        decValue = 12;
                        break;
                    case 'D':
                        decValue = 13;
                        break;
                    case 'E':
                        decValue = 14;
                        break;
                    case 'F':
                        decValue = 15;
                        break;
                    default:
                        decValue = character - '0';
                        break;
                }
                string bin = DecToBin(decValue);
                while (bin.Length < 4)
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