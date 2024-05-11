using System;

namespace Ex01_03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the size of the Sand Clock: ");
            int sandClockSize = int.Parse(Console.ReadLine());
            if (sandClockSize % 2 == 0)
            {
                sandClockSize++;
            }
            PrintHourglass(sandClockSize);
            Console.ReadLine();
        }

        static void PrintHourglass(int i_sandClockSize)
        {
            PrintHalfHourglass(i_sandClockSize, true); // Print the top half
            PrintLine(i_sandClockSize, 0); // Print the middle *
            PrintHalfHourglass(i_sandClockSize, false); // Print the bottom half
        }

        static void PrintHalfHourglass(int i_sandClockSize, bool i_UpperPart)
        {
            int halfSize = i_sandClockSize / 2;
            for (int i = 0; i <= halfSize; i++)
            {
                int starsCount = i_UpperPart ? halfSize - i : i;
                if (starsCount != 0) PrintLine(i_sandClockSize, starsCount);
            }
        }

        static void PrintLine(int i_totalRowLength, int i_starsCount)
        {
            int starsInLine = 2 * i_starsCount + 1;
            int spacesCount = (i_totalRowLength - starsInLine) / 2;
            string spaces = new string(' ', spacesCount);
            string starsStr = new string('*', starsInLine);
            Console.WriteLine(spaces + starsStr + spaces);
        }
    }
}