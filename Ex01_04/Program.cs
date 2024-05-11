using System;

namespace Ex01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of 10 characters :");
            string inputString = Console.ReadLine();

            while (inputString.Length != 10)
            {
                Console.WriteLine("Invalid input. Please ensure the string is exactly 10 characters long.");
                Console.WriteLine("Enter a string of 10 characters :");
                inputString = Console.ReadLine();
            }
            
            // Check if it is Palindrome
            bool isPalindrome = IsPalindrome(inputString, 0, inputString.Length - 1);
            Console.WriteLine("Is the string a palindrome? " + isPalindrome);

            // Check if the number is a multiple of 4
            if (int.TryParse(inputString, out int number))
            {
                bool isMultipleOfFour = number % 4 == 0;
                Console.WriteLine("Is the number a multiple of 4? " + isMultipleOfFour);
            }

            // Count uppercase and lowercase letters
            int uppercaseCount = 0, lowercaseCount = 0;
            foreach (char c in inputString)
            {
                if (char.IsUpper(c)) uppercaseCount++;
                else if (char.IsLower(c)) lowercaseCount++;
            }

            if (char.IsLetter(inputString[0])) // Assuming that the presence of one letter implies all are letters
            {
                Console.WriteLine("Number of uppercase letters: " + uppercaseCount);
                Console.WriteLine("Number of lowercase letters: " + lowercaseCount);
            }
        }

        static bool IsPalindrome(string i_inputString, int i_startIndex, int i_endIndex)
        {
            if (i_startIndex >= i_endIndex) return true;
            if (i_inputString[i_startIndex] != i_inputString[i_endIndex]) return false;
            return IsPalindrome(i_inputString, i_startIndex + 1, i_endIndex - 1);
        }
    }
}
