using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int numberOfInputs = 3;
            List<int> inputDecimalNumberList = new List<int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string binaryInput;
                do
                {
                    Console.WriteLine("Enter a 9-digit Binary Number:");
                    binaryInput = Console.ReadLine();
                } while (!IsValidBinaryInput(binaryInput));
                
                int decimalRepresentation = ConvertBinaryToDecimal(binaryInput);
                inputDecimalNumberList.Add(decimalRepresentation);
            }
            
            inputDecimalNumberList.Sort();
            DisplayResults(inputDecimalNumberList);

        }
        
        static bool IsValidBinaryInput(string i_binaryNumber)
        {
            return i_binaryNumber.Length == 9 && i_binaryNumber.All(c => c == '0' || c == '1');
        }
        
        static int ConvertBinaryToDecimal(string i_binaryNumber)
        {
            int decimalValue = 0;
            foreach (char bit in i_binaryNumber)
            {
                decimalValue = (decimalValue << 1) | (bit - '0');
            }
            return decimalValue;
        }
        
        static void DisplayResults(List<int> i_DecimalNumberList)
        {
            Console.WriteLine("Sorted numbers: " + string.Join(", ", i_DecimalNumberList));
        
            int totalOnes = i_DecimalNumberList.Sum(num => Convert.ToString(num, 2).Count(c => c == '1'));
            int totalZeros = i_DecimalNumberList.Sum(num => Convert.ToString(num, 2).Count(c => c == '0'));
            Console.WriteLine("Average ones: " + (double)totalOnes / i_DecimalNumberList.Count);
            Console.WriteLine("Average zeros:" +(double)totalZeros / i_DecimalNumberList.Count);

            int countPowersOfTwo = i_DecimalNumberList.Count(num => (num & (num - 1)) == 0);
            Console.WriteLine("Powers of two count: " + countPowersOfTwo );

            int strictlyIncreasingCount = i_DecimalNumberList.Count(IsStrictlyMonotonicallyIncreasing);
            Console.WriteLine("Strictly monotonically increasing count: {strictlyIncreasingCount}");

            Console.WriteLine("Greatest number: " + i_DecimalNumberList.Max());
            Console.WriteLine("Smallest number: " + i_DecimalNumberList.Min());

            Console.ReadLine();
        }
        
        static bool IsStrictlyMonotonicallyIncreasing(int i_number)
        {
            string digits = i_number.ToString();
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] >= digits[i + 1])
                    return false;
            }
            return true;
        }
    }
}