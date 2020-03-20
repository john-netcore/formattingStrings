using System;

namespace FormattingStrings
{
    public class DateAndTimeFormatting
    {
        public static void ExamplesWithDateFormatting()
        {
            var date = DateTime.Now;
            System.Console.WriteLine("Short date (d): {0:d}", date);
            System.Console.WriteLine("Long date (D): {0:D}", date);
            System.Console.WriteLine("Month (M): {0:M}", date);
            System.Console.WriteLine("Year (Y) {0:Y}", date);
        }

        public static void ExamplesWithTimeFormatting()
        {
            var date = DateTime.Now;
            System.Console.WriteLine("Short time (t): {0:t}", date);
            System.Console.WriteLine("Long time (T): {0:T}", date);
        }
    }
}