using System;

namespace BinConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinToDec("10000000"));
        }
        static double BinToDec(string binary)
        {
            double decValue = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                int number = binary[i] - '0' ;
                double power = binary.Length - 1 -i;
                decValue += Math.Pow(2,power)*number;
            }
            return decValue;
        }
    }
}