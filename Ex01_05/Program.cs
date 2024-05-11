using System;

namespace Ex01_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an 8-digit integer:");
            string inputNumber = Console.ReadLine();
            while (!IsValidInput(inputNumber))
            {
                Console.WriteLine("Invalid input. Please ensure the number is exactly 8 digits.");
                Console.WriteLine("Please enter an 8-digit integer:");
                inputNumber = Console.ReadLine();
            }

            int number = int.Parse(inputNumber);
            int unitDigit = number % 10;
            int countSmallerThanUnits = 0;
            int countDivisibleBy3 = 0;
            int largestDigit = 0;
            double sumDigits = 0;
        
            for (int i = 0; i < 8; i++)
            {
                int digit = number % 10;
                if (digit < unitDigit) countSmallerThanUnits++;
                if (digit % 3 == 0) countDivisibleBy3++;
                if (digit > largestDigit) largestDigit = digit;
                sumDigits += digit;
                number /= 10;
            }

            double averageDigits = sumDigits / 8;

            Console.WriteLine("Number of digits smaller than the units digit: " + countSmallerThanUnits);
            Console.WriteLine("Number of digits that can be divided by 3: " + countDivisibleBy3);
            Console.WriteLine("The largest digit: " + largestDigit);
            Console.WriteLine("Average of the digits: " + averageDigits);
        }

        static bool IsValidInput(string input)
        {
            if (input.Length != 8) return false;
            foreach (char c in input)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }
    }
}