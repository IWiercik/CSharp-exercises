using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decValue = BinToDec("1111");
            string octalValue = "";
            while (decValue > 0)
            {
                octalValue = octalValue.Insert(0,(decValue % 8).ToString());
                decValue = decValue / 8;
            }
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
