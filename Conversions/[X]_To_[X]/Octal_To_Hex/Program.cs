using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            octalToHex(255);
        }
        static void octalToHex(int octValue)
        {
            int decValue = octalToDec(octValue);
            decToHex(decValue);

        }
        static int octalToDec(int octValue)
        {
            string startingValue = octValue.ToString();
            int result = 0;
            for (int i = 0; i < startingValue.Length; i++)
            {
                result += (int)(Math.Pow(8, startingValue.Length - i - 1) * (startingValue[i] - '0'));
            }
           return result;
        }
        static void decToHex(int decValue)
        {
            int startingValue = decValue;
            string result = "";
            while (startingValue > 0)
            {
                switch (startingValue % 16)
                {
                    case 10:
                        result = "A" + result;
                        break;
                    case 11:
                        result = "B" + result;
                        break;
                    case 12:
                        result = "C" + result;
                        break;
                    case 13:
                        result = "D" + result;
                        break;
                    case 14:
                        result = "E" + result;
                        break;
                    case 15:
                        result = "F" + result;
                        break;
                    default:
                        result = startingValue % 16 + result;
                        break;
                }
                startingValue = startingValue / 16;
            }
            Console.WriteLine(result);
        }
    }
}