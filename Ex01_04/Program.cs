using System;

namespace Ex01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string of 10 characters (letters or digits only): ");
            string input = Console.ReadLine();

            if (input.Length != 10 || !IsLettersOrDigits(input))
            {
                Console.WriteLine("Invalid input. Please ensure it contains exactly 10 English letters or digits.");
                return;
            }

            // Palindrome check using recursion
            Console.WriteLine("Is the string a Palindrome? " + IsPalindrome(input, 0, input.Length - 1));

            // Multiplication check
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine("Is the input a multiplication of 4? " + (number % 4 == 0));
            }

            // Letter count
            int uppercaseCount = 0, lowercaseCount = 0;
            foreach (char c in input)
            {
                if (char.IsUpper(c)) uppercaseCount++;
                if (char.IsLower(c)) lowercaseCount++;
            }

            Console.WriteLine("Number of capital letters: " + uppercaseCount);
            Console.WriteLine("Number of lowercase letters: " + lowercaseCount);
        }

        static bool IsPalindrome(string s, int start, int end)
        {
            if (start >= end) return true;
            if (s[start] != s[end]) return false;
            return IsPalindrome(s, start + 1, end - 1);
        }

        static bool IsLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsLetterOrDigit(c)) return false;
            }
            return true;
        }
    }
}
