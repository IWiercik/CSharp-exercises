using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decValue = BinToDec("1111111110");
            string hexValue = decValue.ToString("X");
            Console.WriteLine(hexValue);
        }

        static int BinToDec(string binary)
        {
            double decValue = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                int number = binary[i] - '0'; // Convert string to number by - "0"
                double power = binary.Length - 1 - i;
                decValue += Math.Pow(2, power) * number;
            }
            return (int) decValue;
        }
    }
}
