using System;

namespace Ex01_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int diamondMiddleSize = 5;  
            PrintDiamond(diamondMiddleSize, 1, true);
            Console.ReadLine();
        }
        static void PrintDiamond(int i_diamondMiddleSize, int i_currentSize, bool i_isIncreasing)
        {
            PrintLine(i_diamondMiddleSize, i_currentSize);
            if (i_currentSize == i_diamondMiddleSize && i_isIncreasing)
                i_isIncreasing = false;
        
            if (i_isIncreasing)
                PrintDiamond(i_diamondMiddleSize, i_currentSize + 1, true);
            else if (i_currentSize > 1)
                PrintDiamond(i_diamondMiddleSize, i_currentSize - 1, false);
        }

        static void PrintLine(int i_diamondMiddleSize, int i_starsCount)
        {
            int spacesCount = i_diamondMiddleSize - i_starsCount;
            string spaces = new string(' ', spacesCount);
            string starsInLine = new string('*', 2 * i_starsCount - 1);
            Console.WriteLine(spaces + starsInLine + spaces);
        }
    }
}