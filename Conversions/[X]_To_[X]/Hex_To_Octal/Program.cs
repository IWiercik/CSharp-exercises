using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HexToOctal("FF");
        }
        static void HexToOctal(string hexValue)
        {
            int decValue = HexToDec(hexValue);
            Console.WriteLine(decToOctal(decValue));
        }
        static int HexToDec(string hexValue)
        {
            string startingValue = hexValue;
            int result = 0;
            for (int i = 0; i < startingValue.Length; i++)
            {
                char actualChar = startingValue[i];
                int charDecValue;
                switch (actualChar)
                {
                    case 'A':
                        charDecValue = 10;
                        break;
                    case 'B':
                        charDecValue = 11;
                        break;
                    case 'C':
                        charDecValue = 12;
                        break;
                    case 'D':
                        charDecValue = 13;
                        break;
                    case 'E':
                        charDecValue = 14;
                        break;
                    case 'F':
                        charDecValue = 15;
                        break;
                    default:
                        charDecValue = (int)actualChar;
                        break;
                }
                result += (int)(Math.Pow(16, startingValue.Length - i - 1) * charDecValue);
            }
            return result;
        }
        static string decToOctal(int decValue)
        {
            int startingValue = decValue;
            string result = "";
            while (startingValue > 0)
            {
                result = startingValue % 8 + result;
                startingValue = startingValue / 8;
            }
           return result;
        }
    }
}