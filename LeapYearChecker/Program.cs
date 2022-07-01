using System;

namespace LeapYearChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(args[0]);
            Console.WriteLine(IsLeapYear(year));
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 100 != 0 || year % 400 == 0) && year % 4 == 0;
        }
    }
}

